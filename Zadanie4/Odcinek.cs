using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class Odcinek
    {
        Punkt a, b;
        internal double dlugosc;
        public Odcinek(Punkt a, Punkt b)
        {
            this.a = a;
            this.b = b;
            dlugosc = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }
    }
}
