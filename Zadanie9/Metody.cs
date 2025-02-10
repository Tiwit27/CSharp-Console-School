using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    internal class Metody
    {
        public static void WypelnijTablice(int[] tablica)
        {
            Random rand = new Random();
            for(int i = 0; i< tablica.Length; i++)
            {
                tablica[i] = rand.Next(101);
            }
            Console.WriteLine();
        }
        public static void WyswietlTablice(int[] tablica)
        {
            foreach(int i in tablica)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
        }
        public static void WypelnijTablice(int[,]tablica)
        {
            Random rand = new Random();
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for(int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i,j] = rand.Next(101);
                }
                
            }
            Console.WriteLine();
        }
        public static void WyswietlTablice(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write($"{tablica[i,j], 4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void WypelnijTablice(int[,,] tablica)
        {
            Random rand = new Random();
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    for (int k = 0; k < tablica.GetLength(2); k++)
                    {
                        tablica[i, j, k] = rand.Next(101);
                    }
                }

            }
            Console.WriteLine();
        }
        public static void WyswietlTablice(int[,,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    for (int k = 0; k < tablica.GetLength(2); k++)
                    {
                        Console.Write($"{tablica[i, j, k],4}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void WyswietlTablice(int[][] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int k = 0; k < tablica[i].Length; k++)
                {
                    Console.Write($"{tablica[i][k],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void WyswietlTablice(int[][][] tablica)
        {
            for(int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    for (int k = 0; k < tablica[i][j].Length; k++)
                    {
                        Console.Write($"{tablica[i][j][k],4}");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
