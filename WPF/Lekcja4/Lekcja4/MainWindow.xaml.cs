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

namespace Lekcja4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(e.Source == buttonStackPanel)
            {
                OknoStackPanel osp = new OknoStackPanel();
                osp.ShowDialog();
            }
            else if (e.Source == buttonWrapPanel)
            {
                OknoWrapPanel owp = new OknoWrapPanel();
                owp.ShowDialog();
            }
            else if(e.Source == buttonGrid)
            {
                OknoGrid og = new OknoGrid();
                og.ShowDialog();
            }
            else if (e.Source == buttonUniformGrid)
            {
                OknoUniformGrid oug = new OknoUniformGrid();
                oug.ShowDialog();
            }
            else if (e.Source == buttonCanvas)
            {
                OknoCanvas oc = new OknoCanvas();
                oc.ShowDialog();
            }
            else if (e.Source == buttonDockPanel)
            {
                OknoDockPanel odp = new OknoDockPanel();
                odp.ShowDialog();
            }
        }
    }


}