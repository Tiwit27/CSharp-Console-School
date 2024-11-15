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
        int iloscRdzeni;
        double taktowanie;
        int pamiecCache;
        string Nazwa { get; set; }
        string Socked { get; set; }
        int IloscRdzeni {
            get { return iloscRdzeni; }
            set 
            {
                if (value <= 0)
                {
                    iloscRdzeni = 1;
                }
                else
                {
                    iloscRdzeni = value;
                }
            }
        }
        double Taktowanie
        {
            get { return taktowanie; }
            set 
            { 
                if (value <= 0)
                {
                    taktowanie = 1;
                }
                else
                {
                    taktowanie = value;
                }
            }
        }
        int PamiecCache
        {
            get { return pamiecCache; }
            set 
            { 
                if (value <= 0)
                {
                    pamiecCache = 1;
                }
                else
                {
                    pamiecCache = value;
                }
            }
        }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY PROCESORA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj nazwę procesora: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj ilość rdzeni procesora: ");
            IloscRdzeni = int.Parse(Console.ReadLine());
            Console.Write("Podaj taktowanie procesora: ");
            Taktowanie = double.Parse(Console.ReadLine());
            Console.Write("Podaj pamięć cache procesora: ");
            PamiecCache = int.Parse(Console.ReadLine());
            Console.Write("Podaj socked procesora: ");
            Socked = Console.ReadLine();
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Procesor \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Nazwa: {Nazwa}\n" +
                $"Ilość Rdzeni: {IloscRdzeni}\n" +
                $"Taktowanie: {Taktowanie} GHz\n" +
                $"Pamięć Cache: {PamiecCache} MB\n" +
                $"Socked: {Socked}\n");
        }
    }
}
