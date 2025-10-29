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

namespace Zadanie9
{
    // w oknie głównym wyraz ciągu arytmetycznego, geometrycznego i fibonacciego
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ca.Click += Ca_Click;
            cg.Click += Cg_Click;
            cf.Click += Cf_Click;
        }

        private void Cf_Click(object sender, RoutedEventArgs e)
        {
            CiagFibonacciego cf = new();
            cf.ShowDialog();
        }

        private void Cg_Click(object sender, RoutedEventArgs e)
        {
            CiagGeometryczny cg = new();
            cg.ShowDialog();
        }

        private void Ca_Click(object sender, RoutedEventArgs e)
        {
            CiagArytmetyczny ca = new();
            ca.ShowDialog();
        }
    }
}