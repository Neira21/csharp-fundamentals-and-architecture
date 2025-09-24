using System;

namespace AdapterDemo
{
  // Interfaz esperada
  public interface ITarget
  {
    void Request();
  }

  // Clase existente con una interfaz diferente
  public class LegacyService
  {
    public void SpecificRequest()
    {
      Console.WriteLine("Llamada al servicio legado");
    }
  }

  // Adapter que traduce la interfaz
  public class LegacyServiceAdapter : ITarget
  {
    private LegacyService _legacyService;
    public LegacyServiceAdapter(LegacyService legacyService)
    {
      _legacyService = legacyService;
    }
    public void Request()
    {
      _legacyService.SpecificRequest();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      ITarget service = new LegacyServiceAdapter(new LegacyService());
      service.Request();
    }
  }
}

