using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja19
{
    internal class Pracownik: Osoba
    {
        private string wyksztalcenie;

        public Pracownik(string wyksztalcenie, string imie, string nazwisko) : base(imie, nazwisko)
        {
            this.wyksztalcenie = wyksztalcenie;
        }
    }
}
