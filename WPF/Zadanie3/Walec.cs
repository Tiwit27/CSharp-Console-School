using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zadanie3
{
    public class Walec:IFigura
    {
        public string WzorPole => "P=2*π*r*(r+h)";
        public string WzorObjetosc => "V=π*r²*h";
        public string ImagePath => "grafika/walce.jfif";
        public string[] GetParameters()
        {
            return new[] { "R", "H" };
        }
        public double ObliczPole(List<double> p)
        {
            return 2 * Math.PI * p[0] * (p[0] + p[1]);
        }
        public double ObliczObjetosc(List<double> p)
        {
            return Math.PI * Math.Pow(p[0], 2) * p[1];
        }
    }
}
