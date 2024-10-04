using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Matematyka
    {
        public static double Suma(double x, double y)
        {
            return x + y;
        }
        public static double Iloczyn(double x, double y)
        {
            return x * y;
        }
        public static double Iloraz(double x, double y)
        {
            return x / y;
        }
        public static double Potega(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public static double Pierwiastek(double x, int y)
        {
            double wynik = 0;
            if (x < 0 && y % 2 == 1)
            {
                wynik = Math.Pow(-x, (1.0 / y));
                wynik *= -1;
            }
            else
            {
                wynik = Math.Pow(x, (1.0 / y));
            }

            return wynik;
        }
        public static long Silnia(int x)
        {
            long wynik = 1;
            if (x > 0)
            {
                for (int i = x; i > 0; i--)
                {
                    wynik *= i;
                }
            }
            return wynik;
        }
    }
}
