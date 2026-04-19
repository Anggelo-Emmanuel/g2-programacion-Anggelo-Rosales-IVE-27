internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        double valor;

        Console.WriteLine("1 Metros a pies");
        Console.WriteLine("2 Metros a cm");
        Console.WriteLine("3 Metros a pulgadas");

        opcion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese valor:");
        valor = Convert.ToDouble(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine(valor * 3.28084);
                break;
            case 2:
                Console.WriteLine(valor * 100);
                break;
            case 3:
                Console.WriteLine(valor * 39.3701);
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}