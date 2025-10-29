using System.Text;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Zadanie10
{
    //dodawanie, wyświetlanie, usuwanie, wyszukiwanie
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            new Select().ShowDialog();
        }
    }
}