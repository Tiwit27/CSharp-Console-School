using System.Drawing;
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

namespace Zadanie7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        System.Windows.Media.Color correctColor;

        Dictionary<System.Windows.Media.Color, String> colors = new Dictionary<System.Windows.Media.Color, String>()
        {
            { Colors.Red, "Czerwony" },
            { Colors.Green, "Zielony" },
            { Colors.Blue, "Niebieski" },
            { Colors.Yellow, "Żółty" },
            { Colors.Orange, "Pomarańczowy" },
            { Colors.Purple, "Fioletowy" },
            { Colors.Black, "Czarny" },
            { Colors.White, "Biały" },
            { Colors.Gray, "Szary" },
            { Colors.Brown, "Brązowy" },
        };

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.Background is SolidColorBrush brush)
            {
                if (brush.Color == correctColor)
                {
                    text.Text = "DOBRZE!";
                }
            }

        }

        private void ReloadColors()
        {
            var random = new Random();

            colors = colors
                .OrderBy(x => random.Next())
                .ToDictionary(x => x.Key, x => x.Value);

            var choosenColorID = random.Next(0, 3);
            colorText.Text = colors.ElementAt(choosenColorID).Value;
            correctColor = colors.ElementAt(choosenColorID).Key;
            stColor.Background = new SolidColorBrush(colors.ElementAt(0).Key);
            ndColor.Background = new SolidColorBrush(colors.ElementAt(1).Key);
            stColor.Background = new SolidColorBrush(colors.ElementAt(2).Key);
        }
    }
}