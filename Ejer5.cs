internal class Program
{
    private static void Main(string[] args)
    {
        int cantidad, opcion;
        double precio = 650 * 1.12;
        double total, descuento = 0, pagar;

        Console.WriteLine("Cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1 Efectivo");
        Console.WriteLine("2 Tarjeta");
        Console.WriteLine("3 Vale");
        opcion = Convert.ToInt32(Console.ReadLine());

        total = precio * cantidad;

        switch (opcion)
        {
            case 1:
                descuento = total * 0.10;
                break;
            case 2:
                descuento = total * 0.05;
                break;
            case 3:
                descuento = total * 0.15;
                break;
        }

        pagar = total - descuento;

        Console.WriteLine("Total sin descuento: " + total);
        Console.WriteLine("Descuento: " + descuento);
        Console.WriteLine("Total a pagar: " + pagar);
    }
}