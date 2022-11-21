using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace API.Models;

public class User
{
    [Key]
    public int userId { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public byte[] passwordHash { get; set; }
    public byte[] passwordSalt { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; } 

    public string country { get; set; } = String.Empty;
    public string address { get; set; } = String.Empty;
    public int postCode { get; set; } = 0;

}