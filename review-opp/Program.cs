

using review_opp.Inscripcion;

//Student student1 = new Student("Alice", 20, 3.5);
//Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, GPA: {student1.GPA}, Major: {student1.Major}");


// No se puede crear un objeto de una clase abstracta
//Person person1 = new Person("Bob", 45);
//Console.WriteLine(person1.GetInfo());

// Pero se puede crear una variable de tipo Person (clase abstracta) a partir de un objeto que hereda de Person en este caso Student
Person person1 = new Student("Alice", 20, 3.5, "Computer Science");
Console.WriteLine(person1.GetInfo());

Student student1 = new Student("Alice", 20, 3.5, "Computer Science");

Console.WriteLine(student1.GetInfo());
Console.WriteLine(student1.SMajor);


Console.WriteLine("----- Uso del método GetInfo con prefijo -----");
Console.WriteLine(student1.GetInfo("Estudiante:"));





