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
            liczba1.Text = "Liczba " + l1;
            liczba2.Text = "Liczba " + l2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LosujLiczby();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}