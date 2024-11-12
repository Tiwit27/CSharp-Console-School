using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Procesor
    {
        string Nazwa { get; set; }
        int IloscRdzeni {
            get { return IloscRdzeni; }
            set { if (value <= 0) IloscRdzeni = 1; }
        }
        double Taktowanie
        {
            get { return Taktowanie; }
            set { if (value <= 0) Taktowanie = 1; }
        }
        int PamiecCache
        {
            get { return PamiecCache; }
            set { if (value <= 0) PamiecCache = 1; }
        }
        internal void PodajParametry()
        {
            Console.Write("Podaj nazwę procesora: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj ilość rdzeni procesora: ");
            IloscRdzeni = int.Parse(Console.ReadLine());
            Console.Write("Podaj taktowanie procesora: ");
            Taktowanie = double.Parse(Console.ReadLine());
            Console.Write("Podaj pamięć cache procesora: ");
            PamiecCache = int.Parse(Console.ReadLine());
        }
        internal void WypiszParametry()
        {
            Console.WriteLine($"Dysk: \n" +
                $"Nazwa: {Nazwa}\n" +
                $"Ilość Rdzeni: {IloscRdzeni}\n" +
                $"Taktowanie: {Taktowanie}\n" +
                $"Pamięć Cache: {PamiecCache}\n\n");
        }
    }
}
