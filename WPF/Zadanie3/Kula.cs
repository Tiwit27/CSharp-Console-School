using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zadanie3
{
    public class Kula:IFigura
    {
        public string WzorPole => "P=4*π*r²";
        public string WzorObjetosc => "V=4/3*πr³";
        public string ImagePath => "grafika/kula.png";
        public string[] GetParameters()
        {
            return new[] { "R"};
        }
        public double ObliczPole(List<double> p)
        {
            return 4 * Math.PI * Math.Pow(p[0], 2);
        }
        public double ObliczObjetosc(List<double> p)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(p[0], 3);
        }
    }
}
