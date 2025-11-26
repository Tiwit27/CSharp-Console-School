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
    /// Logika interakcji dla klasy DodajUczniaOkno.xaml
    /// </summary>
    public partial class DodajUczniaOkno : Window
    {
        public DodajUczniaOkno()
        {
            InitializeComponent();
        }
        private void DodajUcznia()

        {
            string danePolaczenia = "server=localhost;user=root;password='';database=szkola";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            try
            {
                polaczenie.Open();
                string nazwisko1 = nazwisko.Text.Trim();
                string imie1 = imie.Text.Trim();
                //if (!string.IsNullOrWhiteSpace(wplata.Text))
                //{
                //    int wplata1 = Convert.ToInt32(wplata.Text);
                //}

                int klasa1 = klasa.SelectedIndex + 1;
                int wychowawca1 = wychowawca.SelectedIndex + 1;
                string kwerenda = $"INSERT INTO uczniowie (nazwisko, imie, klasa, wychowawca, wplataRR)" +
                $"VALUES ('{nazwisko1}', '{imie1}', {klasa1}, {wychowawca1}, {Convert.ToInt32(wplata.Text)})";

                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);

                int wynik = cmd.ExecuteNonQuery();

                if (wynik > 0)
                    MessageBox.Show("Uczeń został dodany.");
                else
                    MessageBox.Show("Nie udało się dodać ucznia.");


                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                //dataGrid.ItemsSource = dt.DefaultView;


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

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            DodajUcznia();
        }

        private void wyswietl_Click(object sender, RoutedEventArgs e)
        {
            WyswietlBazeOkno wyswietlBazePoDodaniu = new WyswietlBazeOkno();
            wyswietlBazePoDodaniu.ShowDialog();
        }
    }
}
