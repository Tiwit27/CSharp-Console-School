using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace BazyDanych
{
    /// <summary>
    /// Logika interakcji dla klasy WyswietlBazeOkno.xaml
    /// </summary>
    public partial class WyswietlBazeOkno : Window
    {
        public WyswietlBazeOkno()
        {
            InitializeComponent();
            string danePolaczenia = "server=localhost;user=root;password='';database=szkola";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            try
            {
                polaczenie.Open();
                string kwerenda = "SELECT uczniowie.id as 'id ucznia',uczniowie.nazwisko,uczniowie.imie as 'imię ucznia',klasa.nazwaKlasy as klasa, wychowawca.nazwisko as 'nazwisko wychowawcy' ,wychowawca.imie as 'imię wychowawcy' ,uczniowie.wplataRR FROM uczniowie INNER JOIN klasa ON uczniowie.klasa=klasa.id INNER JOIN wychowawca ON uczniowie.wychowawca=wychowawca.id";
                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
            finally
            {
                polaczenie.Close();
            }
        }
    }
}
