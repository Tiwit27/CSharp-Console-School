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

namespace Zadanie12
{
    public partial class MainWindow : Window
    {
        bool przesuwanie = false;
        Point pozycjaKursoraNaCanvasie, pozycjaKursoraNaObazku;
        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void LButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(dog, Canvas.GetLeft(dog) - 10);
        }
        private void TButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(dog, Canvas.GetTop(dog) - 10);
        }
        private void RButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(dog, Canvas.GetLeft(dog) + 10);
        }
        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(dog, Canvas.GetTop(dog) + 10);
        }

        private void dog_MouseDown(object sender, MouseButtonEventArgs e)
        {
            przesuwanie = true;
            dog.Cursor = Cursors.Hand;
            dog.CaptureMouse();
            pozycjaKursoraNaObazku = e.GetPosition(dog);
        }

        private void dog_MouseMove(object sender, MouseEventArgs e)
        {
            if(przesuwanie)
            {
                pozycjaKursoraNaCanvasie = e.GetPosition(canvas);

                Canvas.SetLeft(dog, pozycjaKursoraNaCanvasie.X - pozycjaKursoraNaObazku.X);
                Canvas.SetTop(dog, pozycjaKursoraNaCanvasie.Y - pozycjaKursoraNaObazku.Y);
            }
        }

        private void dog_MouseUp(object sender, MouseButtonEventArgs e)
        {
            przesuwanie = false;
            dog.Cursor = Cursors.Arrow;
            dog.ReleaseMouseCapture();
        }
    }
}