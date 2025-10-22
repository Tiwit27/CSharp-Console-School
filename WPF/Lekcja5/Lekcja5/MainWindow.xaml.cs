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

namespace Lekcja5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            owoce.SelectedIndex = 0;
            owoce.SelectionChanged += Owoce_SelectionChanged;
        }

        private void Owoce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (owoce.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Wybrałeś Jabłko 1");
                    break;
                case 1:
                    MessageBox.Show("Wybrałeś Banan 1");
                    break;
                case 2: 
                    MessageBox.Show("Wybrałeś Pomarańczę 1");
                    break;
                case 3:
                    MessageBox.Show("Wybrałeś Kiwi 1");
                    break;
            }
        }

        private void owoce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(owoce.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Wybrałeś Jabłko");
                    break;
                case 1:
                    MessageBox.Show("Wybrałeś Banan");
                    break;
                case 2:
                    MessageBox.Show("Wybrałeś Pomarańczę");
                    break;
                case 3:
                    MessageBox.Show("Wybrałeś Kiwi");
                    break;
            }
        }
    }
}