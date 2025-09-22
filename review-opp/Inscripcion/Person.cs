

namespace review_opp.Inscripcion
{
  public abstract class Person
  {
    public string Name { get; set; } = "";
    protected int Age { get; set; } = 0;

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public abstract string GetInfo();

    public abstract string GetInfo(string prefix);

  }
}