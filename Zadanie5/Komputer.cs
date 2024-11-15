using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Komputer
    {
        Procesor procesor = new();
        RAM ram = new();
        KartaGraficzna kartaGraficzna = new();
        Dysk dysk = new();
        Zasilacz zasilacz = new();
        PlytaGlowna plytaGlowna = new();
        Obudowa obudowa = new();
        internal void PodajParametryKomputera()
        {
            Check(procesor.PodajParametry);
            Check(ram.PodajParametry);
            Check(kartaGraficzna.PodajParametry);
            Check(dysk.PodajParametry);
            Check(zasilacz.PodajParametry);
            Check(plytaGlowna.PodajParametry);
            Check(obudowa.PodajParametry);
        }
        internal void WypiszParametryKomputera()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ten Komputer składa się z: \n");
            Console.ForegroundColor = ConsoleColor.White;
            procesor.WypiszParametry();
            ram.WypiszParametry();
            kartaGraficzna.WypiszParametry();
            dysk.WypiszParametry();
            zasilacz.WypiszParametry();
            plytaGlowna.WypiszParametry();
            obudowa .WypiszParametry();
        }
        void Check(Action method)
        {
            while (true)
            {
                try
                {
                    method();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
        }
    }
}
