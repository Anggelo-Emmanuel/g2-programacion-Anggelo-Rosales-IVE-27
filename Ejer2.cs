internal class Program
{
    private static void Main(string[] args)
    {
        char c;
        Console.WriteLine("Ingrese un caracter: ");
        c= Convert.ToChar(Console.ReadLine());

        switch(c)
        {
            case 'a': case 'e': case 'i': case 'o': case 'u':
                Console.WriteLine("Es vocal");
                break;

            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7':
            case '8': case '9':
                Console.WriteLine("Es digito");
                break;

            default: Console.WriteLine("No es vocal ni digito");
                break ;
        }
    
    }
}