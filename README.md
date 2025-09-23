# Repaso de C# - Fundamentos y Arquitectura

## Comandos

```bash
dotnet new console -n MiAplicacion

# En la carpeta del proyecto
dotnet new console --output .

```

## Introducción a C#

C# es un lenguaje de programación orientado a objetos desarrollado por Microsoft como parte de la plataforma .NET.

## Conceptos Fundamentales

### Programación Orientada a Objetos (POO)

- **Clases y Objetos**: Plantillas y instancias
- **Encapsulación**: Ocultación de datos internos
- **Herencia**: Reutilización de código mediante jerarquías
- **Polimorfismo**: Múltiples formas de un mismo método
- **Abstracción**: Simplificación de conceptos complejos

### Tipos de Datos

```csharp
int numero = 10;
string texto = "Hola mundo";
bool esVerdadero = true;
double decimal = 3.14;
```

### Estructuras de Control

- `if/else` - Condicionales
- `for/while` - Bucles
- `switch` - Selección múltiple
- `try/catch` - Manejo de excepciones

## Arquitectura .NET

- **CLR**: Common Language Runtime
- **BCL**: Base Class Library
- **Compilación**: C# → IL → Código nativo
- **Garbage Collector**: Gestión automática de memoria

## Conceptos Avanzados

- Interfaces y clases abstractas
- Delegados y eventos
- LINQ (Language Integrated Query)
- Async/Await para programación asíncrona
- Generics para reutilización de código

## Patrones de Diseño

### Patrones de Diseño

#### Creacionales

- **Singleton**: Garantiza una única instancia de una clase.
- **Factory Method**: Permite crear objetos sin especificar la clase exacta.
- **Abstract Factory**: Proporciona una interfaz para crear familias de objetos relacionados.

#### Estructurales

- **Adapter**: Permite la interoperabilidad entre interfaces incompatibles.
- **Decorator**: Añade funcionalidades a objetos de manera dinámica.
- **Facade**: Simplifica el acceso a un conjunto de clases complejas.

#### De Comportamiento

- **Observer**: Notifica cambios a múltiples objetos dependientes.
- **Strategy**: Permite cambiar el algoritmo de una operación en tiempo de ejecución.
- **Command**: Encapsula una solicitud como un objeto independiente.

## Buenas Prácticas

- Nomenclatura PascalCase para clases y métodos
- camelCase para variables locales
- Uso de regiones y comentarios XML
- Principios SOLID
