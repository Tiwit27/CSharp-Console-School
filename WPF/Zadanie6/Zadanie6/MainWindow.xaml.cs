using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Zadanie6
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer, timerDate;
        Random r;
        string[] obrazy = new string[]
        {
            "img1.jpg",
            "img2.jpg",
            "img3.jpg",
            "img4.jpg",
            "img5.jpg",
            "img6.jpg",
            "img7.jpg",
        };
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timerDate = new DispatcherTimer();
            timerDate.Interval = TimeSpan.FromSeconds(1);
            timerDate.Tick += TimerDate_Tick;
            r = new Random();
        }

        private void TimerDate_Tick(object? sender, EventArgs e)
        {
            data.Text = DateTime.Now.ToString();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            image.Source = new BitmapImage(new Uri("/Grafika/"+obrazy[r.Next(0,7)], UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            timerDate.Start();
        }
    }
}