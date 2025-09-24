

namespace IteradorDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      var products = new ProductCollection();
      products.Add("Laptop");
      products.Add("Mouse");
      products.Add("Teclado");
      products.Add("Monitor");
      products.Add("USB");

      Console.WriteLine("Recorriendo productos con el patrón Iterador:\n");
      foreach (var product in products)
      {
        Console.WriteLine(product);
      }
    }
  }
}



