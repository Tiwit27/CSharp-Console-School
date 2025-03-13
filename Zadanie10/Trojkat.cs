using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    internal class Trojkat : Figura
    {
        double bokA, bokB, bokC;
        public Trojkat(double bokA, double bokB, double bokC)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
        }
        public override double Obwod()
        {
         
            
                return (bokA + bokB + bokC);
          
         
        }

        public override double Pole()
        {
            double p = (bokA + bokB + bokC)/ 2;
            return (Math.Sqrt(p * (p - bokA) * (p - bokB) * (p - bokC)));
        }

        public bool IsGood()
        {
            double[] boki = [bokA, bokB, bokC];
            boki.Order();
            if (boki[0] + boki[1] < boki[2])
            {
                return false;
            }
            return true;
        }

        public override void WyswietlBoki()
        {
            Console.WriteLine($"Trójkąt o bokach: {bokA}, {bokB} oraz {bokC}");
        }
    }
}
