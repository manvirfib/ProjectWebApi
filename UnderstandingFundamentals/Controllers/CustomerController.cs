using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [HttpGet("getcustomers")]
    public ActionResult<string> CustomersData()
    {
        return Ok("Hello");
    }
}