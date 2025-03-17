using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Prostopadloscian : Figury
    {
        private double a, b, c;
        public Prostopadloscian(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Objetosc()
        {
            return a * b * c;
        }

        public double PolePowierzchni()
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
