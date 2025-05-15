using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zadanie3
{
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        public static void RunCalculator(string pole, string objetosc, string imgPath)
        {
            var k = new Kalkulator();
            k.wzor_pole.Text = pole;
            k.wzor_objetosc.Text = objetosc;
            k.grafika.Source = new BitmapImage(new Uri(imgPath, UriKind.Relative));
            k.Show();
        }
    }
}
