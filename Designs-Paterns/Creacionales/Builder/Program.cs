using System;

namespace BuilderDemo
{
  // Producto complejo
  public class Product
  {
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
      return $"Producto: {Name}\nCategoría: {Category}\nPrecio: {Price}\nDescripción: {Description}";
    }
  }

  // Builder
  public class ProductBuilder
  {
    private Product _product = new Product();

    public ProductBuilder SetName(string name)
    {
      _product.Name = name;
      return this;
    }
    public ProductBuilder SetCategory(string category)
    {
      _product.Category = category;
      return this;
    }
    public ProductBuilder SetPrice(double price)
    {
      _product.Price = price;
      return this;
    }
    public ProductBuilder SetDescription(string description)
    {
      _product.Description = description;
      return this;
    }
    public Product Build()
    {
      return _product;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var builder = new ProductBuilder();
      var product = builder
          .SetName("Laptop")
          .SetCategory("Electrónica")
          .SetPrice(1200)
          .SetDescription("Laptop de alto rendimiento")
          .Build();

      Console.WriteLine(product);
    }
  }
}

