Console.WriteLine("Ejemplo de Listas en C#");

List<string> frutas = new List<string>();
frutas.Add("Manzana");
frutas.Add("Banana");
frutas.Add("Cereza");
frutas.Add("Pera");
frutas.Add("Naranja");

foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}

Console.WriteLine($"Cantidad de frutas: {frutas.Count}");
frutas.Remove("Pera");
frutas.Remove("Naranja");
Console.WriteLine($"Cantidad de frutas despues de eliminar: {frutas.Count}");
Console.WriteLine("Frutas despues de eliminar:");
foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}