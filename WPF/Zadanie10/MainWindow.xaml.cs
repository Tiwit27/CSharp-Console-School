using MySql.Data.MySqlClient;
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

namespace BazyDanych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dodajuczniaokno_Click(object sender, RoutedEventArgs e)
        {
            DodajUczniaOkno dodajuczniaokno = new DodajUczniaOkno();
            dodajuczniaokno.ShowDialog();
        }

        private void wyswietlbazeokno_Click(object sender, RoutedEventArgs e)
        {
            WyswietlBazeOkno wyswietlBazeOkno = new WyswietlBazeOkno();
            wyswietlBazeOkno.ShowDialog();
        }

        private void usunuczniaokno_Click(object sender, RoutedEventArgs e)
        {
            UsunUczniaOkno usunUczniaOkno = new UsunUczniaOkno();
            usunUczniaOkno.ShowDialog();
        }

        private void wyszukajuczniaokno_Click(object sender, RoutedEventArgs e)
        {
            WyszukajUczniaOkno wyszukajUczniaOkno = new WyszukajUczniaOkno();
            wyszukajUczniaOkno.ShowDialog();
        }
    }
}