using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Images
{
    [Key]
    public int key { get; set; }
    public string path { get; set; }
}