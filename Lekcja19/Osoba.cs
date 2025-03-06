using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    internal class Osoba
    {
        private string nazwisko;
        private string imie;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Jestem pracownikiem, nazywam się: {imie} {nazwisko}");
        }
    }
}
