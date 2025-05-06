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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        char[] znaki = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '='];
        string haslo = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        bool CheckPassLenght(string Haslo, int setLength)
        {
            if(Haslo.Length >= setLength)
            {
                return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //65, 95 -> A,Z
            //97, 122 -> a,z
            int _iloscZnakow;
            string haslo = "";
            Random r = new Random();
            if(int.TryParse(iloscZnakow.Text, out _iloscZnakow) && _iloscZnakow > 0)
            {
                int i = 0;
                if (cyfry.IsChecked == true)
                {
                    haslo += r.Next(0, 10);
                    i++;
                }
                if(CheckPassLenght(haslo, _iloscZnakow))
                {
                    goto show;
                }
                if (znakiSpecjalne.IsChecked == true)
                {
                    haslo += r.GetItems(znaki, 1)[0];
                    i++;
                }
                if (CheckPassLenght(haslo, _iloscZnakow))
                {
                    goto show;
                }
                if (wielkoscLiter.IsChecked == true)
                {
                    haslo += (char)r.Next(65,90);
                    i++;
                }
                if (CheckPassLenght(haslo, _iloscZnakow))
                {
                    goto show;
                }
                for (; i < _iloscZnakow; i++)
                {
                    haslo += (char)r.Next(97, 122);
                }
            show:
                this.haslo = haslo;
                MessageBox.Show(haslo);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {imie.Text} {nazwisko.Text} {stanowisko.Text} Hasło: {this.haslo}");
        }
    }
}