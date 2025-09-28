// Ejemplo if / else if / else
int edad = 26;

if (edad < 18)
{
    Console.WriteLine("Eres menor de edad");
}
else if (edad >= 18 && edad < 25)
{
    Console.WriteLine("Eres joven");
}
else
{
    Console.WriteLine("Eres adulto");
}

// Ejemplo switch
Console.Write("Seleccionar opcion: ");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Realizar una suma");
        break;
    case 2:
        Console.WriteLine("Realizar una resta");
        break;
    case 3:
        Console.WriteLine("Realizar una multiplicacion");
        break;
    case 4:
        Console.WriteLine("Realizar una division");
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}

