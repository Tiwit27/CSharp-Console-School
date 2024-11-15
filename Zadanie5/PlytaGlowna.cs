using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class PlytaGlowna
    {
        string Nazwa { get; set; }
        string Chipset { get; set; }
        string Socket { get; set; }
        string ObslugiwanyTypPamieci { get; set; }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY PŁYTY GŁÓWNEJ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj nazwę płyty głównej: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj chipset płyty głównej: ");
            Chipset = Console.ReadLine();
            Console.Write("Podaj socked płyty głównej: ");
            Socket = Console.ReadLine();
            Console.Write("Podaj obsługiwany typ pamięci RAM: ");
            ObslugiwanyTypPamieci = Console.ReadLine();
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Płyta główna: \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Nazwa: {Nazwa}\n" +
                $"Chipset: {Chipset}\n" +
                $"Socket: {Socket} GB\n" +
                $"Obsługiwany Typ Pamięci RAM: {ObslugiwanyTypPamieci}\n");
        }
    }
}
