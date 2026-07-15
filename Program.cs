internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Eithan Klee\n"+
            "Grado: IVC - Clave 16\n"+
            "===CONVERSIONES===");
        double metros, resultado;
        Console.Write("Dame una medida en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1- Milimetros\n" +
            "2- Centimetros\n" +
            "3- Decimetros\n" +
            "4- Hectometros\n" +
            "5- Kilometros\n" +
            "6- Salir\n" +
            "Seleccione una opcion []:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSION A MILIMETROS");
                resultado = metros * 1000;
                Console.WriteLine("Los metros " + metros + "en milimetros es: " + resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSION A CENTIMETROS");
                resultado = metros * 100;
                Console.WriteLine("Los metros " + metros + "en centimetros es: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSION A DECIMETROS");
                resultado = metros * 10;
                Console.WriteLine("Los metros " + metros + "en decimetros es: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSION A HECTOMETROS");
                resultado = metros / 100;
                Console.WriteLine("Los metros " + metros + "en hectometros es: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSION A KILOMETROS");
                resultado = metros / 1000;
                Console.WriteLine("Los metros " + metros + "en kilometros es: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para salir, presione una tecla...");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opcion Invalida...");
                break;
        }
    }
}