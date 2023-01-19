using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Models;

public class ProductCategory
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    [JsonIgnore]
    public List<Product> products { get; set; }
}