using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class RAM
    {
        int pojemnosc;
        int taktowanie;
        string Producent { get; set; }
        string RodzajPamieci { get; set; }
        int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                if (value <= 0)
                {
                    pojemnosc = 2;
                }
                else
                {
                    pojemnosc = value;
                }
            }
        }
        int Taktowanie
        {
            get { return taktowanie; }
            set 
            { 
                if (value <= 0)
                {
                    taktowanie = 1000;
                }
                else
                {
                    taktowanie = value;
                }
                    
            }
        }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY RAMU");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj producenta ramu: ");
            Producent = Console.ReadLine();
            Console.Write("Podaj rodzaj pamięci ram: ");
            RodzajPamieci = Console.ReadLine();
            Console.Write("Podaj pojemność pamieci ramu: ");
            Pojemnosc = int.Parse(Console.ReadLine());
            Console.Write("Podaj taktowanie ramu: ");
            Taktowanie = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"RAM: \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Producent: {Producent}\n" +
                $"Rodzaj Pamięci: {RodzajPamieci}\n" +
                $"Pojemność Pamięci: {Pojemnosc} GB\n" +
                $"Taktowanie: {Taktowanie} MHz\n");
        }
    }
}
