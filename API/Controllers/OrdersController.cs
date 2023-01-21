using API.DTOs.Orders;
using API.Models;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly PrintCenterDbContext _context;

    public OrdersController(PrintCenterDbContext context)
    {
        this._context = context;
    }

    [HttpPost("createOrder")]
    public async Task<ActionResult> createOrder(OrderDTO order)
    {
        
        await this._context.Orderhistory.AddAsync(new OrderHistory
        {
         
        });
        return Ok("");
    }

}