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

    [HttpGet("getdiscount")]
    public ActionResult<decimal> CustomerDiscount(int amount)
    {
        var applicableDiscount = new List<IDiscountStrategy>
        {
            new FestivalDiscount()
        };

        DiscountCalculator discountCalculator = new DiscountCalculator(applicableDiscount);

        return discountCalculator.CalculateTotalDiscount(amount);
    }
}