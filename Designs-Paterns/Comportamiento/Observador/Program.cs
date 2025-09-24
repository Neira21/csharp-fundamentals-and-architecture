namespace ObservadorDemo
{
  // Interfaz del observador
  public interface IObserver
  {
    void Update(string message);
  }

  // Interfaz del sujeto
  public interface ISubject
  {
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
  }

  // Implementación concreta del sujeto
  public class NewsAgency : ISubject
  {
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
      observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
      observers.Remove(observer);

      if (observer is Person person)
      {
        Console.WriteLine($"{person.Name} se ha desuscrito de la agencia de noticias.");
      }
      else
      {
        Console.WriteLine("Un observador se ha desuscrito de la agencia de noticias.");
      }
    }

    public void Notify(string message)
    {
      foreach (var observer in observers)
      {
        observer.Update(message);
      }
    }

    public void PublishNews(string news)
    {
      Console.WriteLine($"Agencia publica noticia: {news}");
      Notify(news);
    }
  }

  // Implementación concreta de observador
  public class Person : IObserver
  {
    public string Name { get; set; }
    public Person(string name)
    {
      Name = name;
    }
    public void Update(string message)
    {
      Console.WriteLine($"{Name} recibió la noticia: {message}");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var agency = new NewsAgency();
      var alice = new Person("Alice");
      var bob = new Person("Bob");

      // Se suscriben los observadores a la agencia de noticias
      agency.Attach(alice);
      agency.Attach(bob);

      // el subject publica noticias, y esto llama al metodo notify que a su vez llama al metodo update de cada observador
      agency.PublishNews("Nuevo producto lanzado!");
      agency.PublishNews("Oferta especial esta semana!");

      agency.Detach(bob);
      agency.PublishNews("Solo Alice recibe esta noticia.");
    }
  }
}
