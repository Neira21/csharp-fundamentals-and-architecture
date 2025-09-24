using System;

namespace SingletonDemo
{
  // Ejemplo de Singleton: Logger
  public class Logger
  {
    private static Logger _instance;
    private static readonly object _lock = new object();

    // Constructor privado para evitar instanciación externa
    private Logger() { }

    public static Logger Instance
    {
      get
      {
        if (_instance == null)
        {
          lock (_lock)
          {
            if (_instance == null)
              _instance = new Logger();
          }
        }
        return _instance;
      }
    }

    public void Log(string message)
    {
      Console.WriteLine($"[LOG] {message}");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var logger1 = Logger.Instance;
      var logger2 = Logger.Instance;

      logger1.Log("Mensaje desde logger1");
      logger2.Log("Mensaje desde logger2");

      Console.WriteLine($"¿Ambos loggers son la misma instancia? {object.ReferenceEquals(logger1, logger2)}");
    }
  }
}


