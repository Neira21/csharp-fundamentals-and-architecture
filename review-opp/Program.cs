
Student student1 = new Student("Alice", 20, 3.5);
student1.major = "Computer Science";



public class Student
{
  public string Name { get; set; }
  public int Age { get; set; }
  public double GPA { get; set; }
  public string major { get; set; }

  public Student(string name, int age, double gpa)
  {
    Name = name;
    Age = age;
    GPA = gpa;
  }

  public Student()
  {
  }


}