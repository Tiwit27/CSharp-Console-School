using System.Collections.ObjectModel;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> listaRzeczy;
        public MainWindow()
        {
            InitializeComponent();

            listaRzeczy = new ObservableCollection<string>();
            Lista.ItemsSource = listaRzeczy;
        }

        private void DodajDoListy(object sender, RoutedEventArgs e)
        {
            listaRzeczy.Add("A");

            MessageBox.Show(Lista.SelectedIndex.ToString());//mozna uzyc do usuwania czy cos
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}