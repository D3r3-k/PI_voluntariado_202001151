Console.WriteLine("Bloque 1: Practica 1");

// Pedir el nombre del usuario
Console.Write("Por favor, introduce tu nombre: ");
string nombre = Console.ReadLine();
// Pedir la edad del usuario
Console.Write("Introduce tu edad: ");
string edad = Console.ReadLine();

// Mostramos/Imprimimos en consola
//Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años.");
Console.WriteLine($"Hola {nombre}, tienes {edad} años.");