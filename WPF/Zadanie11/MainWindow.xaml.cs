using Accessibility;
using System.Data.Common;
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
using static System.Net.Mime.MediaTypeNames;

namespace Zadanie11
{
    public partial class MainWindow : Window
    {
        private int emptyRow = 3;
        private int emptyCol = 3;
        private List<DaneObrazka> sourceTab = new ();
        private int time = 0;
        private List<DaneObrazka> baseSourceTab = new List<DaneObrazka>();
        private DispatcherTimer virtualTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            virtualTimer.Tick += Timer_Tick;
            InjectImages();
        }
        private void InjectImages()
        {
            for (int r = 1; r < 5; r++)
            {
                for (int c = 1; c < 5; c++)
                {
                    if (c == 4 && r == 4)
                    {
                        break;
                    }
                    baseSourceTab.Add(new DaneObrazka(new BitmapImage(new Uri($"./Grafika/row-{r}-column-{c}.jpg", UriKind.Relative)), new Point(c - 1, r - 1)));
                }
            }
            var random = new Random();
            for (int r = 1, i = 0; r < 5; r++)
            {
                for (int c = 1; c < 5; c++)
                {
                    if (c == 4 && r == 4)
                    {
                        break;
                    }
                    var img = new System.Windows.Controls.Image
                    {
                        Source = baseSourceTab[i].source,
                        Width = 120,
                        Height = 120,
                    };
                    Grid.SetRow(img, r - 1);
                    Grid.SetColumn(img, c - 1);
                    img.MouseDown += SwitchImage;
                    grid.Children.Add(img);
                    sourceTab.Add(baseSourceTab[i]);
                    baseSourceTab.RemoveAt(i);
                }
            }
        }
        private void StartGame(object sender, RoutedEventArgs e)
        {
            virtualTimer.Interval = TimeSpan.FromSeconds(1);
            virtualTimer.Stop();
            virtualTimer.Start();
            time = 0;
            napis.Text = "";
            MixGrid();
            timer.Text = $"Czas: {time}s";
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            time++;
            timer.Text = $"Czas: {time}s";
        }

        private void MixGrid()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int direction = random.Next(2);
                if (direction == 0)
                {
                    int y;
                    //move y
                    if (emptyRow == 3)
                    {
                        y = emptyRow - 1;
                    }
                    else if (emptyRow == 0)
                    {
                        y = emptyRow + 1;
                    }
                    else
                    {
                        if (random.Next(2) == 0)
                        {
                            y = emptyRow - 1;
                        }
                        else
                        {
                            y = emptyRow + 1;
                        }
                    }
                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    foreach (System.Windows.Controls.Image element in grid.Children)
                    {
                        if (Grid.GetRow(element) == y && Grid.GetColumn(element) == emptyCol)
                        {
                            img = element;
                        }
                    }

                    var tempRow = y;
                    Grid.SetRow(img, emptyRow);
                    emptyRow = tempRow;
                }
                else
                {
                    int x;
                    //move x
                    if (emptyCol == 3)
                    {
                        x = emptyCol - 1;
                    }
                    else if (emptyCol == 0)
                    {
                        x = emptyCol + 1;
                    }
                    else
                    {
                        if (random.Next(2) == 0)
                        {
                            x = emptyCol - 1;
                        }
                        else
                        {
                            x = emptyCol + 1;
                        }
                    }
                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    foreach (System.Windows.Controls.Image element in grid.Children)
                    {
                        if (Grid.GetRow(element) == emptyRow && Grid.GetColumn(element) == x)
                        {
                            img = element;
                        }
                    }

                    var tempCol = x;
                    Grid.SetColumn(img, emptyCol);
                    emptyCol = tempCol;
                }
            }
        }

        private void SwitchImage(object sender, MouseButtonEventArgs e)
        {
            var img = sender as System.Windows.Controls.Image;
            if(Grid.GetColumn(img) == emptyCol && (Grid.GetRow(img) + 1 == emptyRow || Grid.GetRow(img) - 1 == emptyRow))
            {
                var tempRow = Grid.GetRow(img);
                Grid.SetRow(img, emptyRow);
                emptyRow = tempRow;
                Check();
            }
            else if (Grid.GetRow(img) == emptyRow && (Grid.GetColumn(img) + 1 == emptyCol || Grid.GetColumn(img) - 1 == emptyCol))
            {
                var tempCol = Grid.GetColumn(img);
                Grid.SetColumn(img, emptyCol);
                emptyCol = tempCol;
                Check();
            }
        }

        private void Check()
        {
            if(emptyRow == 3 && emptyCol == 3)
            {
                for(int i = 0; i < grid.Children.Count; i++)
                {
                    var img = grid.Children[i] as System.Windows.Controls.Image;
                    if (sourceTab[i].pozycja.X != Grid.GetColumn(img) && sourceTab[i].pozycja.Y != Grid.GetRow(img))
                    {
                        return;
                    }
                }
                virtualTimer.Stop();
                napis.Text = "Gratulacje! Udało Ci się ułożyć obrazek!";
            }
        }
    }
}