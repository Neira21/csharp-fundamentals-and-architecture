namespace Estrategia
{
  public class ShoppingCart
  {
    private IDiscountStrategy _discountStrategy;

    public ShoppingCart(IDiscountStrategy discountStrategy)
    {
      _discountStrategy = discountStrategy;
    }

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
      _discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal total)
    {
      return _discountStrategy.ApplyDiscount(total);
    }
  }
}