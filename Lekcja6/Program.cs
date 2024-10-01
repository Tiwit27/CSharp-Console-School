namespace Lekcja6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj liczbę a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = " + Matematyka.Suma(a,b));
        }
    }
}
