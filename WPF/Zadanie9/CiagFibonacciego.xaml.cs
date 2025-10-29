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
    public partial class CiagFibonacciego : Window
    {
        public CiagFibonacciego()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (int.TryParse(numer.Text, out n))
            {
                if (n > 0)
                {
                    result.Text = "Wynik: " + CiagFibonacciegoRekurencja(int.Parse(numer.Text)).ToString();
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
