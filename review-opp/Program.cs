

using review_opp.Inscripcion;

//Student student1 = new Student("Alice", 20, 3.5);
//Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, GPA: {student1.GPA}, Major: {student1.Major}");


// No se puede crear un objeto de una clase abstracta
//Person person1 = new Person("Bob", 45);
//Console.WriteLine(person1.GetInfo());

// Pero se puede crear una variable de tipo Person (clase abstracta) a partir de un objeto que hereda de Person en este caso Student

// Person person1 = new Student("Alice", 20, 3.5, "Computer Science");
// Console.WriteLine(person1.GetInfo());

// Student student1 = new Student("Alice", 20, 3.5, "Computer Science");

// Console.WriteLine(student1.GetInfo());
// Console.WriteLine(student1.SMajor);


// Console.WriteLine("----- Uso del método GetInfo con prefijo -----");
// Console.WriteLine(student1.GetInfo("Estudiante:"));

Console.WriteLine("-------------------------");






Collection<string> collection = new Collection<string>(5);

// Agregar elementos uno por uno
collection.Add("A");
collection.Add("B");
Console.WriteLine(collection.Count); // 2


Console.WriteLine(collection.GetValid().Length); // 2

Console.WriteLine(string.Join(", ", collection.GetValid()));

// Reemplazar todo el contenido
string[] newElements = { "X", "Y", "Z" };
collection.Set(newElements);
Console.WriteLine(collection.Count); // 3

Console.WriteLine(string.Join(", ", collection.GetValid())); // "X, Y, Z"




//Intentar setear más elementos de la capacidad
// string[] tooMany = { "A", "B", "C", "D", "E", "F" }; // 6 elementos
// collection.Set(tooMany); // ❌ Lanza excepción



// Mostrar el contenido actual del array
void Show()
{
  foreach (string item in collection.Get())
  {
    Console.WriteLine($"'{item}'");
  }
}
