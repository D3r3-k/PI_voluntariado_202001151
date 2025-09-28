// Ejemplo for
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"El numero actual es: {i}");
}
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"El numero actual es: {i}");
}

// Ejemplo foreach
string[] nombres = { "Ana", "Luis", "Carlos", "Marta" };
foreach (var nombre in nombres)
{
    Console.WriteLine($"Hola, {nombre}");
}

// Ejemplo while
int contador = 1;

while (contador <= 25)
{
    Console.WriteLine($"El numero actual es: {contador}");
    contador++;
}

ejemplo do-while

int opcion = -1;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Opcion 1");
    Console.WriteLine("2. Opcion 2");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine()!);
}
while (opcion != 3);