// Se tiene la interface IDiscountStrategy que define el método ApplyDiscount, se aplicará un descuento a las clases de NoDiscount, PercentageDiscount y FixedAmountDiscount.


namespace Estrategia
{
  class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public IDiscountStrategy DiscountStrategy { get; set; }

    public Product(string name, decimal price, IDiscountStrategy discountStrategy)
    {
      Name = name;
      Price = price;
      DiscountStrategy = discountStrategy;
    }

    public decimal GetDiscountedPrice()
    {
      return DiscountStrategy.ApplyDiscount(Price);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Patrón Estrategia - Lista de productos con descuentos\n");

      var products = new[]
      {
        new Product("Laptop", 1200, new PercentageDiscount(10)),
        new Product("Mouse", 25, new NoDiscount()),
        new Product("Teclado", 45, new FixedAmountDiscount(5)),
        new Product("Monitor", 300, new PercentageDiscount(15)),
        new Product("USB", 10, new NoDiscount()),
        new Product("Tablet", 5440, new MinimumAmountDiscount(5000, 500)) // Aplica descuento de 500 si el precio >= 5000
      };

      Console.WriteLine("Producto\t\tPrecio\t\tPrecio con descuento");
      Console.WriteLine("------------------------------------------------------");
      foreach (var p in products)
      {
        Console.WriteLine($"{p.Name}\t\t{p.Price:C}\t\t{p.GetDiscountedPrice():C}");
      }
    }
  }
}
