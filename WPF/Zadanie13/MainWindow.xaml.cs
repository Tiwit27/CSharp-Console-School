using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;

namespace Zadanie13
{
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        bool przesuwanie = false;
        Point pozycjaKursoraNaCanvasie, pozycjaKursoraNaObazku, startPosition;
        int counter = 0;
        List<ElementState> initialLayout = new List<ElementState>();

        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in canvas.Children)
            {
                initialLayout.Add(new ElementState
                {
                    Element = el,
                    Left = Canvas.GetLeft(el),
                    Top = Canvas.GetTop(el)
                });
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Image img)
            {
                startPosition = new Point(Canvas.GetLeft(img), Canvas.GetTop(img));
                Panel.SetZIndex(img, 1);
                przesuwanie = true;
                img.Cursor = Cursors.Hand;
                img.CaptureMouse();
                pozycjaKursoraNaObazku = e.GetPosition(img);
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            foreach (var el in initialLayout)
            {
                UIElement element = el.Element;
                Canvas.SetLeft(element, el.Left);
                Canvas.SetTop(element, el.Top);
                canvas.Children.Add(element);
                if (element is EmptySlot clearSlot)
                {
                    clearSlot.Reset();
                }
            }
        }

        private void dog_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Image img)
            {
                if (przesuwanie)
                {
                    pozycjaKursoraNaCanvasie = e.GetPosition(canvas);
                    Canvas.SetLeft(img, pozycjaKursoraNaCanvasie.X - pozycjaKursoraNaObazku.X);
                    Canvas.SetTop(img, pozycjaKursoraNaCanvasie.Y - pozycjaKursoraNaObazku.Y);
                }
            }
        }

        private void dog_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is Image img)
            {
                przesuwanie = false;
                img.Cursor = Cursors.Arrow;
                img.ReleaseMouseCapture();

                double canvasWidth = canvas.ActualWidth;
                string imgName = Path.GetFileNameWithoutExtension(img.Source.ToString());
                EmptySlot slot = FindName(imgName) as EmptySlot;
                double right = Canvas.GetRight(slot);
                double top = Canvas.GetTop(slot);

                double left = canvasWidth - right - 135;
                Rect slotRect = new Rect(left, top, 135, 135);
                if(slotRect.Contains(pozycjaKursoraNaCanvasie))
                {
                    slot.Update($"/Obrazki/{imgName}.jpeg");

                    canvas.Children.Remove(img);
                    player.Open(new Uri($"Dzwieki/{imgName}.wav", UriKind.Relative));
                    player.Play();
                    counter++;
                    if(counter == 6)
                    {
                        reset.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    Canvas.SetLeft(img, startPosition.X);
                    Canvas.SetTop(img, startPosition.Y);
                    Panel.SetZIndex(img, 0);
                }
            }
        }
    }
}