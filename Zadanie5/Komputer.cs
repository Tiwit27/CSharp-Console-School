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
        internal void PodajParametryKomputera()
        {
            procesor.PodajParametry();
            ram.PodajParametry();
            kartaGraficzna.PodajParametry();
            dysk.PodajParametry();
        }
        internal void WypiszParametryKomputera()
        {
            Console.Clear();
            Console.WriteLine("Ten Komputer składa się z: \n");
            procesor.WypiszParametry();
            ram.WypiszParametry();
            kartaGraficzna.WypiszParametry();
            dysk.WypiszParametry();
        }
    }
}
