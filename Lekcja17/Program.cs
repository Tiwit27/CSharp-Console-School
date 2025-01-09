using System;

namespace Lekcja17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tablice wielowymiarowe
            var random = new Random();
            Console.WriteLine("Tablice prostokątne dwuwymiarowe");
            var t1 = new int[4, 5];
            for (int i = 0; i < t1.GetLength(0); i++)
            {
                for (int j = 0; j < t1.GetLength(1); j++)
                {
                    t1[i,j] = random.Next(10);
                }
            }
            for (int i = 0; i < t1.GetLength(0); i++)
            {
                for (int j = 0; j < t1.GetLength(1); j++)
                {
                    Console.Write(t1[i, j] + " ");
                }
                Console.Write("\n");
            }
            var t2 = new int[5, 6];
            Console.WriteLine("Dwuwymiarowa wypełniona funkcją:");
            ReturnRandomTab(t2);
            WriteTab(t2);
            var t3 = new int[5, 2, 3];
            Console.WriteLine("Trójwymiarowa wypełniona funkcją:");
            ReturnRandomTab(t3);
            WriteTab(t3);
        }
        private static void ReturnRandomTab(int[,] tab)
        {
            var random = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = random.Next(10);
                }
            }
        }
        private static void WriteTab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }
        private static void ReturnRandomTab(int[,,] tab)
        {
            var random = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int z = 0; z < tab.GetLength(2); z++)
                    {
                        tab[i, j, z] = random.Next(10);
                    }
                }
            }
        }
        private static void WriteTab(int[,,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int z = 0; z < tab.GetLength(2); z++)
                    {
                        Console.Write(tab[i, j, z] + " ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
