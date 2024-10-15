using Matematyka;
using Matematyka2;
namespace Biblioteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mata.Suma(10, 5));
            Console.WriteLine(Mata.Roznica(10, 5));
            Console.WriteLine(Mata2.Iloczyn(10, 5));
            Console.WriteLine(Mata2.Iloraz(10, 5));
            Console.ReadLine();
        }
    }
}
