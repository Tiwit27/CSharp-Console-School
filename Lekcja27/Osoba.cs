using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja27
{
    internal class Osoba
    {
        string nazawisko, imie;
        int wiek;

        public Osoba(string nazawisko, string imie, int wiek)
        {
            this.nazawisko = nazawisko;
            this.imie = imie;
            this.wiek = wiek;
        }
    }
}
