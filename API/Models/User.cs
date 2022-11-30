using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace API.Models;

public class User
{
    [Key]
    public int userId { get; set; }
    public string username { get; set; } = String.Empty;
    public string email { get; set; } = String.Empty;
    public byte[] passwordHash { get; set; } 
    public byte[] passwordSalt { get; set; } 
    public string firstName { get; set; } = String.Empty;
    public string lastName { get; set; } = String.Empty;
    public bool isAdmin { get; set; } = false;
    public string country { get; set; } = String.Empty;
    public string address { get; set; } = String.Empty;
    public int postCode { get; set; } = 0;

}