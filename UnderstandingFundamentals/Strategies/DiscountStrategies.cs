public interface IDiscountStrategy
{
    decimal Calculate(int amount);
}

// Concrete implementations
class FestivalDiscount : IDiscountStrategy
{
    public decimal Calculate(int amount)
    {
        return amount * 0.20m;
    }
}

class CouponDiscount : IDiscountStrategy
{
    public decimal Calculate(int amount)
    {
        return 50;
    }
}

class PremiumCustomerDiscount : IDiscountStrategy
{
    public decimal Calculate(int amount)
    {
        return amount * 0.10m;
    }
}