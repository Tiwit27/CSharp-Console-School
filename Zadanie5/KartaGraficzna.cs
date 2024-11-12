using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class KartaGraficzna
    {
        string Nazwa { get; set; }
        string RodzajZlacza { get; set; }
        int Pamiec
        {
            get { return Pamiec; }
            set { if (value <= 0) Pamiec = 1; }
        }
        string RodzajPamieci { get; set; }
        internal void PodajParametry()
        {
            Console.Write("Podaj nazwę karty graficznej: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj rodzaj złącza karty graficznej: ");
            RodzajZlacza = Console.ReadLine();
            Console.Write("Podaj pamięć karty graficznej: ");
            Pamiec = int.Parse(Console.ReadLine());
            Console.Write("Podaj rodzaj pamięci karty graficznej: ");
            RodzajPamieci = Console.ReadLine();
        }
        internal void WypiszParametry()
        {
            Console.WriteLine($"Dysk: \n" +
                $"Nazwa: {Nazwa}\n" +
                $"Rodzaj Złącza: {RodzajZlacza}\n" +
                $"Pamięć: {Pamiec}\n" +
                $"Rodzaj Pamięci: {RodzajPamieci}\n\n");
        }
    }
}
