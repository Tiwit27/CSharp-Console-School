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
            ReloadColors();
        }

        private int goodScoreValue = 0;
        private int badScoreValue = 0;
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
            { Colors.Pink, "Różowy" },
        };

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.Background is SolidColorBrush brush)
            {
                if (brush.Color == correctColor)
                {
                    face.Source = new BitmapImage(new Uri("graphics/good.png", UriKind.Relative));
                    text.Text = "DOBRZE!";
                    text.Foreground = new SolidColorBrush(Colors.Green);
                    goodScore.Text = $"Dobre: {++goodScoreValue}";
                    ReloadColors();
                }
                else
                {
                    face.Source = new BitmapImage(new Uri("graphics/bad.png", UriKind.Relative));
                    text.Text = "ŹLE!";
                    badScore.Text = $"Złe: {++badScoreValue}";
                    text.Foreground = new SolidColorBrush(Colors.Red);
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
            rdColor.Background = new SolidColorBrush(colors.ElementAt(2).Key);
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            badScoreValue = 0;
            goodScoreValue = 0;
            goodScore.Text = $"Dobre: {goodScoreValue}";
            badScore.Text = $"Złe: {badScoreValue}";
            face.Source = null;
            text.Text = "";
            ReloadColors();
        }
    }
}