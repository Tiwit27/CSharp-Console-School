using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class KartaGraficzna
    {
        int pamiec;
        string Nazwa { get; set; }
        string RodzajZlacza { get; set; }
        int Pamiec
        {
            get { return pamiec; }
            set 
            { 
                if (value <= 0)
                {
                    pamiec = 1;
                }
                else
                {
                    pamiec = value;
                }
            }
        }
        string RodzajPamieci { get; set; }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY KARTY GRAFICZNEJ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj nazwę karty graficznej: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj rodzaj złącza karty graficznej: ");
            RodzajZlacza = Console.ReadLine();
            Console.Write("Podaj pamięć karty graficznej: ");
            Pamiec = int.Parse(Console.ReadLine());
            Console.Write("Podaj rodzaj pamięci karty graficznej: ");
            RodzajPamieci = Console.ReadLine();
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Karta Graficzna: \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Nazwa: {Nazwa}\n" +
                $"Rodzaj Złącza: {RodzajZlacza}\n" +
                $"Pamięć: {Pamiec} GB\n" +
                $"Rodzaj Pamięci: {RodzajPamieci}\n");
        }
    }
}
