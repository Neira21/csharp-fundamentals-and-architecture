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

      agency.Attach(alice);
      agency.Attach(bob);

      agency.PublishNews("Nuevo producto lanzado!");
      agency.PublishNews("Oferta especial esta semana!");

      agency.Detach(bob);
      agency.PublishNews("Solo Alice recibe esta noticia.");
    }
  }
}
