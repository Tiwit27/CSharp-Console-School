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

namespace Lekcja1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        Button b1, b2, b3, b4;
        Button button;
        public MainWindow()
        {

            InitializeComponent();
            this.SizeChanged += MainWindow_SizeChanged;
            

            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            button = new Button();
            button.Content = "Przycisk";
            button.FontSize = 30;
            button.Click += Button_Click;
            WrapPanel.Children.Add(button);


            b1.Content = "Przycisk";
            b1.Width = 900;
            b1.Height = 100;
            b1.FontSize = 18;
            b1.FontWeight = FontWeights.Bold;
            b1.Background = new SolidColorBrush(Color.FromRgb(12, 34, 56));
            b1.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            //WrapPanel.Children.Add(b1);

            b2.Content = "Przycisk";
            b2.Width = 900;
            b2.Height = 100;
            b2.FontSize = 18;
            b2.FontWeight = FontWeights.Bold;
            //WrapPanel.Children.Add(b2);

            b3.Content = "Przycisk";
            b3.Width = 900;
            b3.Height = 100;
            b3.FontSize = 18;
            b3.FontWeight = FontWeights.Bold;
            //WrapPanel.Children.Add(b3);

            b4.Content = "Przycisk";
            b4.Width = 900;
            b4.Height = 100;
            b4.FontSize = 18;
            b4.FontWeight = FontWeights.Bold;
            //WrapPanel.Children.Add(b4);

            b1.Click += B1_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;

        }

        private void MainWindow_StateChanged(object? sender, EventArgs e)
        {
            Sprawdz.Width = this.Width;
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Sprawdz.Width = this.Width;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input.Focus();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            b4.Content = "Kliknąłeś przycisk 4";
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "Klikłeś Przycisk z XML";
        }

        private void emotka_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("test");
            emotka.Source = new BitmapImage(new Uri("grafika/emotika2.png", UriKind.Relative));
        }

        private void input_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                MessageBox.Show("Nacisnąłeś enter");
            }
            else if(e.Key == Key.Escape)
            {
                window.Close(); 
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            b3.Content = "Kliknąłeś przycisk 3";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            b2.Content = "Kliknąłeś przycisk 2";
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "Kliknąłeś przycisk 1";
        }
    }
}