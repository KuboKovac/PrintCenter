using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using API.DTOs;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserContext _userContext;
    private readonly IConfiguration _configuration;

    public AuthController(UserContext userContext, IConfiguration config)
    {
        _userContext = userContext;
        _configuration = config;
    }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(RegisterDto request)
    {
        HashPassword(request.password, out byte[] passwordHash, out byte[] passwordSalt);

        var registeredUsers = await _userContext.Users.ToListAsync();

        foreach (var user in registeredUsers)
        {
            if (user.username == request.username)
            {
                return BadRequest("Username already exist");
            }
            else if (user.email == request.email)
            {
                return BadRequest("Email already taken");
            }
        }

        _userContext.Users.Add(new User
        {
            username = request.username,
            firstName = request.firstName,
            lastName = request.lastName,
            email = request.email,
            passwordHash = passwordHash,
            passwordSalt = passwordSalt
        });
        await _userContext.SaveChangesAsync();

        return Ok("User successfully registered!");
    }


    [HttpPost("login")]
    public async Task<ActionResult<User>> Login(LoginDto request)
    {
        var registeredUsers = await _userContext.Users.ToListAsync();
        User user = new User();

        foreach (var registeredUser in registeredUsers)
        {
            if (registeredUser.username == request.username)
            {
                user.username = request.username;
                user.passwordHash = registeredUser.passwordHash;
                user.passwordSalt = registeredUser.passwordSalt;
                if (VerifyHash(request.password, user.passwordHash, user.passwordSalt))
                {
                    var token = GenerateToken(user);
                    return Ok(token);
                }
                else
                {
                    return BadRequest("Username or password is wrong");
                }
            }
        }
        return BadRequest("Username or password is wrong");
    }


    private void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computedHash.SequenceEqual(passwordHash);
        }
    }

    private string GenerateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.username)
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            _configuration.GetSection("AppSettings:Token").Value));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: credentials
        );
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}