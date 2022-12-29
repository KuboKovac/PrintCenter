namespace API.DTOs.Auth;

public class TokenDto
{
    public string username { get; set; }
    public string token { get; set; }
    
    public TokenDto(string username ,string token)
    {
        this.token = token;
        this.username = username;
    }
}