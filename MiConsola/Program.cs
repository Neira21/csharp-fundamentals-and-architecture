// INTRO ARQUITECTURA

// En este ejemplo se tiene un acoplamiento fuerte porque en la clase MySystem depende directamente de la clase Name.
// Si dentro de la clase MySystem se creara una instancia de Name, cualquier cambio en Name afectaría a MySystem y a otros sistemas que dependan de Name.

// Si crearamos otra clase que implemente la misma funcionalidad que Name, tendríamos que modificar MySystem para que use la nueva clase y eso viola el principio de abierto/cerrado (Open/Closed Principle) ya que habria que cambiarlo en todos los lugares donde se use la clase Name.

// Si se modifica el nombre de la clase o un método, se tendría que cambiar en todos los lugares donde se use la clase Name, lo que puede ser tedioso y propenso a errores.

// Alternativa, usar abstracción e interfaces para desacoplar las dependencias.


using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddTransient<IRepository, NameUnique>();
services.AddTransient<MySystem>();
var serviceProvider = services.BuildServiceProvider();
var system = serviceProvider.GetRequiredService<MySystem>();
system.Run();







// var names = new Name();
// var nameUniques = new NameUnique();
// var system = new MySystem(nameUniques);
// system.Run();



// CAPA DOMINIO
// Interfaces / Aplicación

public interface IRepository
{
  void Save(string name);
  void Delete(string name);
  IEnumerable<string> GetAll();
}




// CAPA DATA
// Componente Names
public class Name : IRepository
{
  private readonly List<string> _names = new List<string>();
  public void Save(string name)
  {
    _names.Add(name);
  }
  public void Delete(string name)
  {
    _names.Remove(name);
  }

  public IEnumerable<string> GetAll()
  {
    return _names;
  }
}

public class NameUnique : IRepository
{
  private readonly HashSet<string> _names = new HashSet<string>();
  public void Save(string name)
  {
    _names.Add(name);
  }
  public void Delete(string name)
  {
    _names.Remove(name);
  }

  public IEnumerable<string> GetAll()
  {
    return _names;
  }
}



// CAPA DE PRESENTACION
// Componente MySystem
public class MySystem
{
  private IRepository _repository;

  public MySystem(IRepository repository)
  {
    _repository = repository;
  }


  public void Run()
  {

    while (true)
    {
      Console.WriteLine("\nSeleccione una opción:");
      Console.WriteLine("1. Agregar nombre");
      Console.WriteLine("2. Mostrar nombres");
      Console.WriteLine("3. Eliminar nombre");
      Console.WriteLine("4. Salir");

      string option = Console.ReadLine() ?? "";
      switch (option)
      {
        case "1":
          Console.Write("Ingrese un nombre: ");
          string name = Console.ReadLine() ?? "";
          if (name != null)
          {
            _repository.Save(name);
          }
          break;
        case "2":
          Console.WriteLine("Nombres guardados:");
          foreach (var n in _repository.GetAll())
          {
            Console.WriteLine($"- {n}");
          }
          break;
        case "3":
          Console.Write("Ingrese un nombre a eliminar: ");
          string nameToDelete = Console.ReadLine() ?? "";
          if (!_repository.GetAll().Contains(nameToDelete))
          {
            Console.WriteLine("El nombre no existe en la lista.");
            break;
          }
          _repository.Delete(nameToDelete);
          break;
        case "4":
          Console.WriteLine("Saliendo del sistema...");
          return;
        default:
          Console.WriteLine("Opción no válida, Ingrese una opción de la lista.");
          continue;
      }

    }
  }


}