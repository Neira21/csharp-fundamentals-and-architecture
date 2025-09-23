
namespace Estrategia;

public class MinimumAmountDiscount : IDiscountStrategy
{
  private readonly decimal _minimumAmount;
  private readonly decimal _discountAmount;

  public MinimumAmountDiscount(decimal minimumAmount, decimal discountAmount)
  {
    _minimumAmount = minimumAmount;
    _discountAmount = discountAmount;
  }

  public decimal ApplyDiscount(decimal total)
  {
    if (total >= _minimumAmount)
    {
      return total - _discountAmount;
    }
    return total;
  }
}