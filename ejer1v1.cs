internal class Program
{
    private static void Main(string[] args)
    {
        double angulo;
        int opcion;

        Console.WriteLine("Ingrese el angulo en grados:");
        angulo = Convert.ToDouble(Console.ReadLine());

        double rad = angulo * Math.PI / 180;

        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(rad));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}