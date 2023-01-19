using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Models;

public class Images
{
    [Key]
    public int id { get; set; }
    public string path { get; set; }
    [JsonIgnore]
    public List<Product> products { get; set; }
}