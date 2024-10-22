using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    internal class Samochod
    {
        private string marka;
        private string silnik;
        private double pojemnoscSilnika;
        private string kolor;
        private int maxPredkosc;
        private int masa;
        private int mocSilnika;
        static internal int LiczObiekty;

        public Samochod()
        {
            LiczObiekty++;
            Console.WriteLine("Powstał nowy obiekt nr: " + LiczObiekty);
        }
        internal void setMarka(string marka)
        {
            this.marka = marka;
        }
        internal string getMarka()
        {
            return marka;
        }
        internal void setSilnik(string silnik)
        {
            this.silnik = silnik;
        }
        internal string getSilnik()
        {
            return silnik;
        }
        internal void setPojemnoscSilnika(double pojemnosc)
        {
            if(pojemnosc < 0)
            {
                this.pojemnoscSilnika = 1.0;
            }
            else
            {
                this.pojemnoscSilnika = pojemnosc;
            }
        }
        internal double getPojemnoscSilnika()
        {
            return pojemnoscSilnika;
        }
        internal void setKolor(string kolor)
        {
            this.kolor = kolor;
        }
        internal string getKolor()
        {
            return kolor;
        }
        internal void setMaxPredkosc(int max)
        {
            if (max < 0)
            {
                this.maxPredkosc = 10;
            }
            else
            {
                this.maxPredkosc = max;
            }
        }
        internal int getMaxPredkosc()
        {
            return maxPredkosc;
        }
        internal void setMasa(int masa)
        {
            if (masa < 0)
            {
                this.masa = 1000;
            }
            else
            {
                this.masa = masa;
            }
        }
        internal int getMasa()
        {
            return masa;
        }
        internal void setMoc(int moc)
        {
            if(moc < 0)
            {
                this.mocSilnika = 10;
            }
            else
            {
                this.mocSilnika = moc;
            }
            
        }
        internal int getMoc()
        {
            return mocSilnika;
        }
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
