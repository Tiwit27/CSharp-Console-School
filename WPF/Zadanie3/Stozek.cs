using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zadanie3
{
    public class Stozek:IFigura
    {
        public string WzorPole => "P=π*r*(r+l)";
        public string WzorObjetosc => "V=(π*r²*h)/3";
        public string ImagePath => "grafika/stozek.png";
        public string[] GetParameters()
        {
            return new[] { "R", "H" };
        }
        public double ObliczPole(List<double> p)
        {
            return Math.PI * p[0] * (p[0] + Math.Sqrt(Math.Pow(p[0], 2) + Math.Pow(p[1], 2)));
        }
        public double ObliczObjetosc(List<double> p)
        {
            return (Math.PI * Math.Pow(p[0], 2) * p[1]) / 3.0;
        }
    }
}
