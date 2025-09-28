// Gestor de Gastos Personales
Console.WriteLine("Bienvenido al Gestor de Gastos Personales");
Console.WriteLine("|=======================================|");
Console.WriteLine("|                 Menu                  |");
Console.WriteLine("|=======================================|");
int opcion = 0;

List<double> montos = new List<double>();
List<string> categorias = new List<string>();
List<string> notas = new List<string>();

do
{
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("1. Registrar gasto");
    Console.WriteLine("2. Listar gastos");
    Console.WriteLine("3. Calcular totales");
    Console.WriteLine("4. Salir");
    Console.Write("Opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        // Registrar gastos (monto, categoria y nota)
        case 1:
            Console.WriteLine("Registrar gasto");
            Console.Write("Ingresar el monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresar la categoria: ");
            string categoria = Console.ReadLine();
            Console.Write("Ingresar una nota (opcional): ");
            string nota = Console.ReadLine();
            montos.Add(monto);
            categorias.Add(categoria);
            notas.Add(nota);
            Console.WriteLine("Gasto registrado exitosamente.");
            break;
        // Listar todos los gastos ingresados
        case 2:
            Console.WriteLine("Listar gastos");
            Console.WriteLine("|=======================================|");
            Console.WriteLine("Categoria   |   Monto   |   Nota");
            Console.WriteLine("|=======================================|");
            for(int i=0; i< montos.Count; i++)
            {
                Console.WriteLine($"{categorias[i]}   |   {montos[i]}   |   {notas[i]}");
            }
            break;
        // Calcular totales (suma, promedio y el gasto mayor)
        case 3:
            Console.WriteLine("Calcular totales");
            double suma = montos.Sum();
            double promedio = montos.Average();
            double mayor = montos.Max();
            Console.WriteLine($"Suma total de gastos: {suma}");
            Console.WriteLine($"Promedio de gastos: {promedio}");
            Console.WriteLine($"Gasto mayor: {mayor}");
            break;
    }
}
while (opcion !=4);



