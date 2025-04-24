using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace Zadanie1
{
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int result = 0;
        public MainWindow()
        {
            InitializeComponent();
            LosujLiczby();
        }
        public void LosujLiczby()
        {
            int l1 = random.Next(1, 11);
            int l2 = random.Next(1, 11);
            result = l1 * l2;
            liczba1.Text = l1.ToString();
            liczba2.Text = l2.ToString();
            wynik.Focus();
            wynik.Clear();
            obraz.Source = new BitmapImage(new Uri("grafika/pytanie.png", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LosujLiczby();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(wynik.Text.Length > 0 && Information.IsNumeric(wynik.Text) && int.Parse(wynik.Text) == result)
            {
                obraz.Source = new BitmapImage(new Uri("grafika/dobrze.png", UriKind.Relative));
            }
            else
            {
                obraz.Source = new BitmapImage(new Uri("grafika/zle.png",UriKind.Relative));
            }
        }

        private void wynik_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Button_Click_1(sender, e);
            }
        }
    }
}