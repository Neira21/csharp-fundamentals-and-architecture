namespace Estrategia
{
  public class NoDiscount : IDiscountStrategy
  {
    public decimal ApplyDiscount(decimal total)
    {
      return total;
    }
  }
}