using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14
{
    internal class Osoba
    {
        string imie;
        string nazwisko;
        private int a = 1;
        internal int b = 2;
        public int c = 3;
        protected int d = 4;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
       

        public void O_Osobie()
        {
            Console.WriteLine($"Nazywam się {imie} {nazwisko}");
        }

        private void m1()
        {
            Console.WriteLine("Jestem metodą prywatną");
        }
        internal void m2()
        {
            Console.WriteLine("Jestem metodą internal");
        }
        public void m3()
        {
            Console.WriteLine("Jestem metodą publiczną");
        }
        protected void m4()
        {
            Console.WriteLine("Jestem metodą protected");
        }
    }
}
