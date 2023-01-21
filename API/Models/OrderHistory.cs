using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class OrderHistory
{
    [Key]
    public int id { get; set; }
    public DateTime orderCreationDate { get; set; }
    public string fName { get; set; }
    public string lName { get; set; }
    public string email { get; set; }
    public string number { get; set; }
    public string address { get; set; }
    public int apartmentNo { get; set; }
    public string postalCode { get; set; }
    public string province { get; set; } = String.Empty;
    public string country { get; set; }
    public int price { get; set; }
    public List<Product> products { get; set; }
}