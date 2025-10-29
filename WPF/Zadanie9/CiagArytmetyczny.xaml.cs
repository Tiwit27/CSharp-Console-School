using System.Windows;
using static Ciagi.CiagiRekurencja;


namespace Zadanie9
{
    public partial class CiagArytmetyczny : Window
    {
        public CiagArytmetyczny()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            int p, r, n;
            if (int.TryParse(pierwszy.Text, out p) && int.TryParse(roznica.Text, out r) && int.TryParse(numer.Text, out n))
            {
                if (n > 0)
                {
                    result.Text = "Wynik: " + CiagArytmetycznyRekurencja(p, r, n);
                }
                else
                {
                    result.Text = "Wyraz ciągu musi być liczbą dodatnią" ;
                }
            }
            else
            {
                result.Text = "Złe dane";
            }
        }

        
    }
}
