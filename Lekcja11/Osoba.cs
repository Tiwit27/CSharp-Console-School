using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11
{
    internal class Osoba
    {
        string nazwisko;
        string imie;
        public Osoba()
        {
            Console.WriteLine("Powstał obiekt klasy Osoba - konstruktor 1");
        }
        public Osoba(string nazwisko)
        {
            Console.WriteLine("Powstał obiekt klasy Osoba - konstruktor 2");
            Nazwisko = nazwisko;
        }
        public Osoba(string nazwisko, string imie)
        {
            Console.WriteLine("Powstał obiekt klasy Osoba - konstruktor 3");
            Nazwisko = nazwisko;
            Imie = imie;
        }
        public void Wizytowka()
        {
            Console.WriteLine($"Imie: {Imie} Nazwisko: {Nazwisko}");
        }
        public string Nazwisko
        {
            get; set;
        }
        public string Imie
        {
            get; set;
        }
    }
}
