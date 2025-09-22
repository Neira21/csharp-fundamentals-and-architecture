namespace Estrategia
{
  public class FixedAmountDiscount : IDiscountStrategy
  {
    private readonly decimal _amount;

    public FixedAmountDiscount(decimal amount)
    {
      _amount = amount;
    }

    public decimal ApplyDiscount(decimal total)
    {
      return total - _amount;
    }
  }
}