using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class ProductBrand
{
    [Key]
    public int id { get; set; }

    public string name { get; set; }
    public string description { get; set; }
    public List<Product> products { get; set; }
}