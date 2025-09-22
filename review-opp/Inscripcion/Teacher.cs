namespace review_opp.Inscripcion;

public class Teacher : Person
{
  public string Subject { get; set; } = "";

  public Teacher(string name, int age, string subject) : base(name, age)
  {
    Subject = subject;
  }

  public override string GetInfo()
  {
    return "Nombre: " + Name + ", Edad: " + Age + ", Asignatura: " + Subject;
  }

  public override string GetInfo(string prefix)
  {
    return prefix + GetInfo();
  }
}