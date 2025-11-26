using MySql.Data.MySqlClient;
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

namespace BazyDanych
{
    /// <summary>
    /// Logika interakcji dla klasy UsunUczniaOkno.xaml
    /// </summary>
    public partial class UsunUczniaOkno : Window
    {
        public UsunUczniaOkno()
        {
            InitializeComponent();
        }
        private void UsunUcznia()
        {
            string danePolaczenia = "server=localhost;user=root;password='';database=szkola";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            try
            {
                polaczenie.Open();
                int id = Convert.ToInt32(usun_id.Text);
                string kwerenda = $"DELETE FROM uczniowie WHERE id = {id}";

                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);

                int wynik = cmd.ExecuteNonQuery();

                if (wynik > 0)
                    MessageBox.Show("Uczeń został usunięty.");
                else
                    MessageBox.Show("Nie ma takiego ucznia. Wpisz poprawne id!");
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

        private void usunBtn_Click(object sender, RoutedEventArgs e)
        {
            UsunUcznia();
        }
    }
}
