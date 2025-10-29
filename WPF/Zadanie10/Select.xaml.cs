using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using static Zadanie10.DataBase;

namespace Zadanie10
{
    public partial class Select : Window
    {
        public Select()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                string query = "SELECT * FROM uczniowie";
                MySqlCommand cmd = new(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas pobierania danych: " + ex.Message);
            }
        }
    }
}
