using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Product
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public ProductCategory category { get; set; }
    public int categoryId { get; set; }
    public ProductBrand brand { get; set; }
    public int brandId { get; set; }
}