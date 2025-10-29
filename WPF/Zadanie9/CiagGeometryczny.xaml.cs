using static Ciagi.CiagiRekurencja;
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

namespace Zadanie9
{
    public partial class CiagGeometryczny : Window
    {
        public CiagGeometryczny()
        {

            InitializeComponent();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            int p, r, n;
            if(int.TryParse(pierwszy.Text, out p) && int.TryParse(roznica.Text, out r) && int.TryParse(numer.Text, out n))
            {
                if (n > 0)
                {
                    result.Text = "Wynik: " + CiagGeometrycznyRekurencja(p, r, n);
                }
                else
                {
                    result.Text = "Wyraz ciągu musi być liczbą dodatnią";
                }
            }
            else
            {
                result.Text = "Złe dane";
            }
        }
    }
}
