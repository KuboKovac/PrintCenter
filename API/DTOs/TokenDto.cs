namespace API.DTOs;

public class TokenDto
{
    public string token { get; set; }

    public TokenDto(string token)
    {
        this.token = token;
    }
}