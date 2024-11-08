using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    //wszystkie wierzchołki, boki, czy istnieje, pole, obwód
    internal class Trojkat
    {
        Punkt a, b, c;
        Odcinek ab, ac, bc;
        public Trojkat(Punkt a, Punkt b, Punkt c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            ab = new(a, b);
            ac = new(a, c);
            bc = new(b, c);
        }

        public void Wypisz()
        {
            if (CzyIstnieje())
            {
                Console.WriteLine("Dane o tym trójkącie:");
                Console.WriteLine("---------------------");
                Console.WriteLine("Wierzchołki:");
                Console.WriteLine($"A: [{a.x},{a.y}]");
                Console.WriteLine($"B: [{b.x},{b.y}]");
                Console.WriteLine($"C: [{c.x},{c.y}]");
                Console.WriteLine("Długość boków:");
                Console.WriteLine($"AB: {ab.dlugosc}");
                Console.WriteLine($"AC: {ac.dlugosc}");
                Console.WriteLine($"BC: {bc.dlugosc}");
                Console.WriteLine("Pole: " + Pole());
                Console.WriteLine("Obwód: " + Obwod());
            }
            else
            {
                Console.WriteLine("Nie można utworzyć");
            }
        }
        bool CzyIstnieje()
        {
            double[] dlugosci = { ab.dlugosc, ac.dlugosc, bc.dlugosc };
            dlugosci = dlugosci.Order().ToArray();
            if (dlugosci[0] + dlugosci[1] > dlugosci[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        double Pole()
        {
            double[] dlugosci = { ab.dlugosc, ac.dlugosc, bc.dlugosc };
            dlugosci = dlugosci.Order().ToArray();
            var result = (dlugosci[0] * dlugosci[1]) / 2;
            return result;
        }
        double Obwod()
        {
            return ab.dlugosc + ac.dlugosc + bc.dlugosc;
        }
    }
}
