using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models;

public class Product
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    [JsonIgnore]
    public ProductCategory category { get; set; }
    [ForeignKey("ProductCategories")]
    public int categoryId { get; set; }
    [JsonIgnore]
    public ProductBrand brand { get; set; }
    [ForeignKey("ProductBrands")]
    public int brandId { get; set; }
    [JsonIgnore]
    public List<OrderHistory> orderHistories { get; set; }
}