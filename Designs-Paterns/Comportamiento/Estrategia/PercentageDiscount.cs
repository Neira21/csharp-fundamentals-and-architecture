namespace Estrategia
{
  public class PercentageDiscount : IDiscountStrategy
  {
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
      _percentage = percentage;
    }

    public decimal ApplyDiscount(decimal total)
    {
      return total - (total * _percentage / 100);
    }
  }
}