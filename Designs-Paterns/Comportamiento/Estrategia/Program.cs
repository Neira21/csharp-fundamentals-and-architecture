Console.WriteLine("Patrón Estrategia!");

namespace Estrategia
{
  class Program
  {
    static void Main(string[] args)
    {
      ShoppingCart cart = new ShoppingCart(new NoDiscount());

      Console.WriteLine("Total sin descuento: " + cart.CalculateTotal(100));

      cart.SetDiscountStrategy(new PercentageDiscount(10));
      Console.WriteLine("Total con descuento del 10%: " + cart.CalculateTotal(100));

      cart.SetDiscountStrategy(new FixedAmountDiscount(15));
      Console.WriteLine("Total con descuento fijo de 15: " + cart.CalculateTotal(100));
    }
  }
}
