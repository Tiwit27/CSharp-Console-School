using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal class Samochod
    {
        internal string marka;
        internal string silnik;
        internal double pojemnoscSilnika;
        internal string kolor;
        internal int maxPredkosc;
        internal double masa;
        internal double mocSilnika;

        public void WyswietDane()
        {
            Console.WriteLine($"Samochód:\n" +
                $"marka: {marka}\n" +
                $"typ silnika: {silnik}\n" +
                $"pojemność: {pojemnoscSilnika}\n" +
                $"kolor: {kolor}\n" +
                $"maksymalna prędkość: {maxPredkosc}\n" +
                $"masa pojazdu: {masa}\n" +
                $"moc silnika: {mocSilnika}");
        }
    }
}
