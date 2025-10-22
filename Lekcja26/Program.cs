using MathLib;

namespace Lekcja26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Podaj x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {MyMath.Suma(x, y)}");
            Console.WriteLine($"{x} - {y} = {MyMath.Roznica(x, y)}");
            Console.WriteLine($"{x} / {y} = {MyMath2.Iloraz(x, y)}");
            Console.WriteLine($"{x} * {y} = {MyMath2.Iloczyn(x, y)}");
            Console.ReadKey();
        }
    }
}
