using System;

namespace FactoryDemo
{
  // Producto base
  public interface IVehicle
  {
    void Drive();
  }

  // Productos concretos
  public class Car : IVehicle
  {
    public void Drive()
    {
      Console.WriteLine("Conduciendo un auto.");
    }
  }

  public class Motorcycle : IVehicle
  {
    public void Drive()
    {
      Console.WriteLine("Conduciendo una motocicleta.");
    }
  }

  // Fábrica
  public static class VehicleFactory
  {
    public static IVehicle CreateVehicle(string type)
    {
      switch (type.ToLower())
      {
        case "car":
          return new Car();
        case "motorcycle":
          return new Motorcycle();
        default:
          throw new ArgumentException("Tipo de vehículo desconocido");
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      IVehicle vehicle1 = VehicleFactory.CreateVehicle("car");
      IVehicle vehicle2 = VehicleFactory.CreateVehicle("motorcycle");

      vehicle1.Drive();
      vehicle2.Drive();
    }
  }
}

