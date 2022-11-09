﻿using System.Security.Cryptography;
using API.DTOs;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController:ControllerBase
{
    public static User user = new User();
    
    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(RegisterDto request)
    {
        HashPassword(request.password, out byte[] passwordHash, out byte[] passwordSalt);
        user.username = request.username;
        user.passwordHash = passwordHash;
        user.passwordSalt = passwordSalt;

        return Ok(user);
    }
    [HttpPost("login")]
    public async Task<ActionResult<User>> Login(LoginDto request)
    {
        if (user.username != request.username)
        {
            return BadRequest("User doesn't exist");
        }
        if (VerifyHash(request.password, user.passwordHash))
        {
            return Ok("token");
        }
        
        return BadRequest("Wrong password");
    }

    


    private void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyHash(string password, byte[] passwordHash)
    {
        using (var hmac = new HMACSHA512(user.passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computedHash.SequenceEqual(passwordHash);
        }
    }
    
}