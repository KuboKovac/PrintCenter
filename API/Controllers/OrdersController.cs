using System.Net.Mail;
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






    private void sendMail()
    {
        MailAddress to = new MailAddress("kubja33@gmail.com");
        MailAddress from = new MailAddress("kubja33@gmail.com");
        MailMessage msg = new MailMessage(from, to);
        msg.Subject = "Fuck off Alabama!";
        msg.Body = "chuju 123345";


    }
}