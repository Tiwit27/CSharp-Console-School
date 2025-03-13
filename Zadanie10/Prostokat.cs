using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    internal class Prostokat : Figura
    {
        double bokA, bokB;
        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }
        public override double Obwod()
        {
            return (2 * (bokA + bokB));
        }

        public override double Pole()
        {
            return (bokA *  bokB);
        }

        public override void WyswietlBoki()
        {
            Console.WriteLine($"Prostokąt o bokach: {bokA} i {bokB}");
        }
    }
}
