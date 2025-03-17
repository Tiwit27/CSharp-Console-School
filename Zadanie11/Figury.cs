using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal interface Figury
    {
        public double PolePowierzchni();
        public double Objetosc();
        public void TypFigury()
        {
            Console.WriteLine("Ta figura to: " + GetType().Name);
        }
    }
}
