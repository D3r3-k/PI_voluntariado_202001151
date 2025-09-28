// Pedirle al usuario 5 numeros enteros 
List<int> numeros = new List<int>();
do
{
    Console.Write("Ingrese un numero entero: ");
    int numero = int.Parse(Console.ReadLine()!);
    numeros.Add(numero);
}
while (numeros.Count != 5);

// Calcular el promedio de los numeros
// Opcion 1
//double promedio = 0;
//for (int i = 0; i < numeros.Count; i++)
//{
//    promedio += numeros[i];
//}
//promedio /= numeros.Count;

// Opcion 2
double promedio = numeros.Average();
Console.WriteLine($"El promedio es: {promedio}");
// Mostrar los numeros mayores al promedio
Console.WriteLine("Los numeros mayores al promedio son:");
foreach (var num in numeros)
{
    if(num > promedio)
    {
        Console.WriteLine(num);
    }
}