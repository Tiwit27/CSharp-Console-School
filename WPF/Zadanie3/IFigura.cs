using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zadanie3
{
    public interface IFigura
    {
        public string WzorPole
        {
            get;
        }
        public string WzorObjetosc
        {
            get;
        }
        public string ImagePath
        {
            get;
        }
        public string[] GetParameters();
        public void GenerateWindow()
        {
            var window = new Kalkulator();
            window.Figura = this;
            window.grafika.Source = new BitmapImage(new Uri(ImagePath, UriKind.Relative));
            window.wzor_pole.Text = WzorPole;
            window.wzor_objetosc.Text = WzorObjetosc;
            foreach(var p in GetParameters())
            {
                var text = new TextBlock();
                text.Text = $"{p}: ";
                text.FontSize = 30;
                window.pola.Children.Add(text);
                var input = new TextBox();
                input.Width = 100;
                input.FontSize = 30;
                input.Margin = new System.Windows.Thickness(10, 0, 10, 0);
                window.pola.Children.Add(input);
            }
            window.Show();
        }
        public double ObliczPole(List<double> parametry);
        public double ObliczObjetosc(List<double> parametry);
    }
}
