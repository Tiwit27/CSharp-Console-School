using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zadanie3
{
    public class Prostopadloscian : IFigura
    {
        public string WzorPole => "P=2(ab+ac+bc)";
        public string WzorObjetosc => "V=a*b*c";
        public string ImagePath => "grafika/prostopadloscian.png";
        public string[] GetParameters()
        {
            return new[] { "A", "B", "C" };
        }
        public double ObliczPole(List<double> p)
        {
            return 2 * ((p[0] * p[1]) + (p[0] * p[2]) + (p[1] * p[2]));
        }
        public double ObliczObjetosc(List<double> p)
        {
            return p[0] * p[1] * p[2];
        }
    }
}
