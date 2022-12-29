using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class OrderHistory
{
    [Key]
    public int id { get; set; }
    public DateTime orderCreationDate { get; set; }
    public List<Product> Products { get; set; }
    public int price { get; set; }
    public User user { get; set; }
}