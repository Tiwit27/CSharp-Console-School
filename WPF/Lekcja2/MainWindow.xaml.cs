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

namespace Lekcja2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name[1])
            {
                case '1':
                    Uklad_stackPanel usp = new Uklad_stackPanel();
                    usp.ShowDialog();
                    break;
                case '2':
                    Uklad_WrapPanel uwp = new Uklad_WrapPanel();
                    uwp.ShowDialog();
                    break;
                    //case '3':
                    //    Uklad_stackPanel usp = new Uklad_stackPanel();
                    //    usp.ShowDialog();
                    //    break;
                    //case '4':
                    //    Uklad_stackPanel usp = new Uklad_stackPanel();
                    //    usp.ShowDialog();
                    //    break;
                    //case '5':
                    //    Uklad_stackPanel usp = new Uklad_stackPanel();
                    //    usp.ShowDialog();
                    //    break;
            }
        }
    }
}