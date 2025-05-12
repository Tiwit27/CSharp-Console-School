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

namespace ZadanieEgzaminacyjne2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Pocztowka.IsChecked == true)
            {
                zdjecie.Source = new BitmapImage(new Uri("/pocztowka.png", UriKind.Relative));
                cena.Text = "Cena: 1 zł";
            }
            else if(List.IsChecked == true)
            {
                zdjecie.Source = new BitmapImage(new Uri("/list.png", UriKind.Relative));
                cena.Text = "Cena: 1.5 zł";
            }
            else
            {
                zdjecie.Source = new BitmapImage(new Uri("/paczka.png", UriKind.Relative));
                cena.Text = "Cena: 10 zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int kodLenght = kod.Text.Length;
            foreach(char l in kod.Text)
            {
                if(char.IsLetter(l))
                {
                    MessageBox.Show("Kod pocztowy powinien składac się z samych cyfr");
                    goto end;
                }
            }
            if(kodLenght == 5)
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            else if (kodLenght != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
        end:;
        }
    }
}