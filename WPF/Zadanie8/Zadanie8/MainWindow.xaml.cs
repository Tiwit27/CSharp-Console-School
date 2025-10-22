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

namespace Zadanie8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            color.SelectionChanged += Color_SelectionChanged;
        }

        private void image_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(selected_image != null)
            {
                selected_image.Source = new BitmapImage(new Uri($"zdjecia/{((ComboBoxItem)image.SelectedItem).Tag}", UriKind.Relative));
            }
        }
        private void Color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(((ComboBoxItem)color.SelectedItem).Tag.ToString()));
        }
    }
}