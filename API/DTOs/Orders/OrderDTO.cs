namespace API.DTOs.Orders;

public class OrderDTO
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string address { get; set; }
    public int postCode { get; set; }
    public string paymentMethod { get; set; }
}