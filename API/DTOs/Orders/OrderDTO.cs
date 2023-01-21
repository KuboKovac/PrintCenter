using API.Models;

namespace API.DTOs.Orders;

public class OrderDTO
{
    public ShippingDataDTO shippingData { get; set; }
    public OrderBasketDTO basket { get; set; }
}

public class ShippingDataDTO
{
    public string fName { get; set; }
    public string lName { get; set; }
    public string email { get; set; }
    public string phoneNum { get; set; }
    public string address { get; set; }
    public int apartmentNo { get; set; }
    public string postalCode { get; set; }
    public string province { get; set; }
    public string country { get; set; }
}
public class OrderBasketDTO
{
    public List<BasketProductDTO> basketItem { get; set; }
}

public class BasketProductDTO
{
    public int amount { get; set; }
    public Product product { get; set; }
}
