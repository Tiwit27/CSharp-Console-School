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

namespace Zadanie3
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IFigura figura;
            switch (((Border)sender).Name)
            {
                case "prostopadloscian":
                    figura = new Prostopadloscian();
                    figura.GenerateWindow();
                    break;
                case "walec":
                    figura = new Walec();
                    figura.GenerateWindow();
                    break;
                case "stozek":
                    figura = new Stozek();
                    figura.GenerateWindow();
                    break;
                case "kula":
                    figura = new Kula();
                    figura.GenerateWindow();
                    break;
            }
        }
    }
}