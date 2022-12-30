using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class ProductCategory
{
    [Key]
    public int id { get; set; }
    public string categoryName { get; set; }
    public List<Product> products { get; set; }
}