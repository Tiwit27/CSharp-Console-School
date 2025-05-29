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
using System.Windows.Threading;

namespace Lekcja3
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer1;
        DispatcherTimer timer2;
        DateTime date;
        Random r;

        public MainWindow()
        {
            InitializeComponent();   
            timer1 = new DispatcherTimer();
            timer2 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer2.Interval = TimeSpan.FromSeconds(1.5);
            timer1.Tick += Timer1_Tick;
            timer2.Tick += Timer2_Tick;
        }

        private void Timer2_Tick(object? sender, EventArgs e)
        {
            Label1.Content = DateTime.Now.ToString();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            Label.Content = int.Parse(Label.Content.ToString()) + 1;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer1.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            timer1.Stop();
        }

        private void Start1_Click(object sender, RoutedEventArgs e)
        {
            timer2.Start();
        }

        private void Stop1_Click(object sender, RoutedEventArgs e)
        {
            timer2.Stop();
        }
    }
}