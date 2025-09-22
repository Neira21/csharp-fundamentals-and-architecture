namespace review_opp.Inscripcion
{
  public class Student : Person, IGrade
  {
    // Propiedades, convención PascalCase Ej: Name, Age, GPA
    public double GPA { get; set; } = 0.0;

    // campo privado, solo se accede desde la clase, Convención camelCase con _, Ej: _name, _age, _gpa
    private string _major = "";

    public string Major
    {
      get
      {
        return _major;
      }
      set
      {
        if (value.Length == 0)
        {
          value = "No definido";
        }
        _major = value;
      }
    }
    public string SMajor
    {
      get
      {
        return "Major: " + _major.ToString();
      }

    }
    // El constructor obliga a que en la creacion del objeto se le pasen los parametros, en este caso, como hereda de Person, se llama al constructor de Person con base
    public Student(string name, int age, double gpa, string major) : base(name, age)
    {
      GPA = gpa;
      Major = major;
    }

    public override string GetInfo()
    {
      return "Nombre: " + Name + ", GPA: " + GPA + ", Edad: " + Age + ", Major: " + Major;
    }

    public override string GetInfo(string prefix)
    {
      return prefix + GetInfo();
    }

    public string GetInfoImportant()
    {
      return "Nombre: " + Name + ", GPA: " + GPA;
    }

  }
}