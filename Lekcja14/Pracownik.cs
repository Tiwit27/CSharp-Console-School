using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14
{
    internal class Pracownik : Osoba
    {
        string wyksztalcenie;
        string stanowisko;
        public Pracownik(string imie, string nazwisko, string wyksztalcenie, string stanowisko) : base(imie, nazwisko)
        {
            this.wyksztalcenie = wyksztalcenie;
            this.stanowisko = stanowisko;
        }
        public void O_Pracowniku()
        {
            O_Osobie();
            Console.WriteLine($"Mam wykształcenie {wyksztalcenie} oraz pracuję na stanowisku {stanowisko}");
        }
    }
}
