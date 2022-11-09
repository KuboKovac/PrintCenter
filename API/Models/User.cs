using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class User
{
    [Key]
    public int userId { get; set; }
    public string username { get; set; }
    public byte[] passwordHash { get; set; }
    public byte[] passwordSalt { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string country { get; set; }
    public string address { get; set; }
    public int postCode { get; set; }
}