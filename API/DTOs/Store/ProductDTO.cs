using API.Models;

namespace API.DTOs.Store;

public class ProductDTO
{
    public string name { get; set; }
    public string description { get; set; }
    public string brand { get; set; }
    public string category { get; set; }
}