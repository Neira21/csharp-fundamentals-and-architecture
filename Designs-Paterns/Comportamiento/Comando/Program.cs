namespace ComandoDemo
{
  // Interfaz del comando
  public interface ICommand
  {
    void Execute();
  }

  // Receptor
  public class Light
  {
    public void TurnOn()
    {
      Console.WriteLine("La luz está encendida.");
    }
    public void TurnOff()
    {
      Console.WriteLine("La luz está apagada.");
    }
  }

  // Comando concreto para encender la luz
  public class TurnOnCommand : ICommand
  {
    private Light _light;
    public TurnOnCommand(Light light)
    {
      _light = light;
    }
    public void Execute()
    {
      _light.TurnOn();
    }
  }

  // Comando concreto para apagar la luz
  public class TurnOffCommand : ICommand
  {
    private Light _light;
    public TurnOffCommand(Light light)
    {
      _light = light;
    }
    public void Execute()
    {
      _light.TurnOff();
    }
  }

  // Invocador
  public class RemoteControl
  {
    private List<ICommand> _commands = new List<ICommand>();
    public void AddCommand(ICommand command)
    {
      _commands.Add(command);
    }

    public void ExecuteCommand(int index)
    {
      if (index >= 0 && index < _commands.Count)
        _commands[index].Execute();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var light = new Light();
      var turnOn = new TurnOnCommand(light);
      var turnOff = new TurnOffCommand(light);

      var remote = new RemoteControl();
      remote.AddCommand(turnOn);
      remote.AddCommand(turnOff);

      // Ejecutar solo el primer comando (encender la luz)
      remote.ExecuteCommand(0);
    }
  }
}
