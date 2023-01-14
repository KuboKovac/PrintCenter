using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Images
{
    [Key]
    public int id { get; set; }
    public string path { get; set; }
}