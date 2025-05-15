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
    public partial class Kula : Window
    {
        public Kula()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pole = 4 * Math.PI * Math.Pow(float.Parse(r.Text), 2); 
            var objetosc = 4.0/3.0 * Math.PI * Math.Pow(float.Parse(r.Text), 3);
            p.Text = "P = " + pole;
            v.Text = "V = " + objetosc;
        }
    }
}
