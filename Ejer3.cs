internal class Program
{
    private static void Main(string[] args)
    {
        int sector, cantidad;
        double precio = 0,total;
        Console.WriteLine("1 Palco");
        Console.WriteLine("2 Tribuna");
        Console.WriteLine("3 Preferencia");
        Console.WriteLine("4 General");

        sector=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        switch(sector)
        {
            case 1: precio = 300; break;
            case 2: precio = 125; break;
            case 3: precio = 75; break;
            case 4: precio = 50; break;
                default: Console.WriteLine("Opcion invalida"); break;  
        }
        total = precio * cantidad;
        Console.WriteLine("El total a pagar seria de Q:" + total);
    }
}