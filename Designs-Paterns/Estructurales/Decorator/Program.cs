using System;

namespace DecoratorDemo
{
  // Componente base
  public interface ICoffee
  {
    string GetDescription();
    double GetCost();
  }

  // Componente concreto
  public class SimpleCoffee : ICoffee
  {
    public string GetDescription() => "Café simple";
    public double GetCost() => 5.0;
  }

  // Decorador base
  public abstract class CoffeeDecorator : ICoffee
  {
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
      _coffee = coffee;
    }
    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual double GetCost() => _coffee.GetCost();
  }

  // Decoradores concretos
  public class MilkDecorator : CoffeeDecorator
  {
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription() => _coffee.GetDescription() + ", con leche";
    public override double GetCost() => _coffee.GetCost() + 1.5;
  }

  public class SugarDecorator : CoffeeDecorator
  {
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription() => _coffee.GetDescription() + ", con azúcar";
    public override double GetCost() => _coffee.GetCost() + 0.5;
  }

  class Program
  {
    static void Main(string[] args)
    {
      ICoffee coffee = new SimpleCoffee();
      Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

      coffee = new MilkDecorator(coffee);
      Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

      coffee = new SugarDecorator(coffee);
      Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");
    }
  }
}
