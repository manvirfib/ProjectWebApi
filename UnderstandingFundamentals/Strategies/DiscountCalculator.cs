class DiscountCalculator
{
    readonly IEnumerable<IDiscountStrategy> strategies;

    public DiscountCalculator(IEnumerable<IDiscountStrategy> strategies)
    {
        this.strategies = strategies;
    }

    public decimal CalculateTotalDiscount(int amount)
    {
        return strategies.Sum(p => p.Calculate(amount));
    }
}