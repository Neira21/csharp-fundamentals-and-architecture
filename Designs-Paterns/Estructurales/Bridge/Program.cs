using System;

namespace BridgeDemo
{
  // Implementación
  public interface IRenderer
  {
    void Render(string shape);
  }

  public class VectorRenderer : IRenderer
  {
    public void Render(string shape)
    {
      Console.WriteLine($"Dibujando {shape} como vector");
    }
  }

  public class RasterRenderer : IRenderer
  {
    public void Render(string shape)
    {
      Console.WriteLine($"Dibujando {shape} como raster");
    }
  }


  // Abstracción
  public abstract class Shape
  {
    protected IRenderer renderer;
    public Shape(IRenderer renderer)
    {
      this.renderer = renderer;
    }
    public abstract void Draw();
  }

  public class Circle : Shape
  {
    public Circle(IRenderer renderer) : base(renderer) { }
    public override void Draw()
    {
      renderer.Render("círculo");
    }
  }

  public class Square : Shape
  {
    public Square(IRenderer renderer) : base(renderer) { }
    public override void Draw()
    {
      renderer.Render("cuadrado");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Shape circle = new Circle(new VectorRenderer());
      Shape square = new Square(new RasterRenderer());

      circle.Draw();
      square.Draw();
    }
  }
}
