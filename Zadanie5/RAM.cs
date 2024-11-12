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
        string Producent { get; set; }
        string RodzajPamieci { get; set; }
        int Pojemnosc
        {
            get { return Pojemnosc; }
            set { if (value <= 0) Pojemnosc = 2; }
        }
        int Taktowanie
        {
            get { return Taktowanie; }
            set { if (value <= 0) Taktowanie = 1000; }
        }
        internal void PodajParametry()
        {
            Console.Write("Podaj producenta ramu: ");
            Producent = Console.ReadLine();
            Console.Write("Podaj rodzaj pamięci ram: ");
            RodzajPamieci = Console.ReadLine();
            Console.Write("Podaj pojemność pamieci ramu: ");
            Pojemnosc = int.Parse(Console.ReadLine());
            Console.Write("Podaj taktowanie ramu: ");
            Taktowanie = int.Parse(Console.ReadLine());
        }
        internal void WypiszParametry()
        {
            Console.WriteLine($"Dysk: \n" +
                $"Producent: {Producent}\n" +
                $"Rodzaj Pamięci: {RodzajPamieci}\n" +
                $"Pojemność Pamięci: {Pojemnosc}\n" +
                $"Taktowanie: {Taktowanie}\n\n");
        }
    }
}
