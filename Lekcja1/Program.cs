//using System;

namespace Lekcja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 5));
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
               
            }
            Console.WriteLine("Koniec");
            //
            while(true)
            {
                Console.WriteLine("Pętla");
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
