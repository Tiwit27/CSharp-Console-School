using Microsoft.VisualBasic;
using System;
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

namespace Zadanie4
{
    public partial class MainWindow : Window
    {
        StackPanel main, first, second, last;
        Random random = new Random();
        TextBlock liczba1, liczba2;
        Image obraz;
        TextBox wynik;
        int result = 0;
        //zrobić zadanie tabliczka mnożenia, pisząc tylko w .cs
        public MainWindow()
        {
            InitializeComponent();
            main = new StackPanel();
            first = new StackPanel();
            second = new StackPanel();
            last = new StackPanel();
            //b1 = new Button();
            //b2 = new Label();
            //b3 = new Button();
            //sp1 = new StackPanel();
            //sp2 = new StackPanel();
            //sp3 = new StackPanel();
            //sp1.Children.Add(sp2);
            //sp1.Children.Add(sp3);
            //sp2.Children.Add(b1);
            //sp2.Children.Add(b2);
            //sp3.Children.Add(b3);
            //b1.Content = "Button 1";
            //b2.Content = "Button 2";
            //b3.Content = "Button 3";
            //b1.FontSize = 35;
            //b2.FontSize = 35;
            //b3.FontSize = 35;
            //this.Content = sp1;
            //sp1.Orientation = Orientation.Vertical;
            //sp2.Orientation = Orientation.Horizontal;
            //sp3.Orientation = Orientation.Horizontal;
            main.Orientation = Orientation.Vertical;
            this.Content = main;
            main.Children.Add(first);
            main.Children.Add(second);
            main.Children.Add(last);
            //last.Height = second.Height * 2;
            first.Orientation = Orientation.Horizontal;
            first.HorizontalAlignment = HorizontalAlignment.Center;
            second.Orientation = Orientation.Horizontal;
            second.HorizontalAlignment = HorizontalAlignment.Center;
            last.Orientation = Orientation.Horizontal;
            last.HorizontalAlignment = HorizontalAlignment.Center;
            var b1 = new Border() { BorderThickness = new Thickness(5), BorderBrush = Brushes.Black, Margin = new Thickness(10), Width = 200 };
            first.Children.Add(b1);
            liczba1 = new TextBlock() { Text = "Liczba 1", Name = "Liczba1", FontSize = 40, Padding = new Thickness(10), TextAlignment = TextAlignment.Center };
            b1.Child = liczba1;
            first.Children.Add(new TextBlock() { Text = "*", FontSize = 80, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center });
            var b2 = new Border() { BorderThickness = new Thickness(5), BorderBrush = Brushes.Black, Margin = new Thickness(10), Width = 200 };
            first.Children.Add(b2);
            liczba2 = new TextBlock() { Text = "Liczba 2", Name = "Liczba2", FontSize = 40, Padding = new Thickness(10), TextAlignment = TextAlignment.Center };
            b2.Child = liczba2;
            first.Children.Add(new TextBlock() { Text = "=", FontSize = 80, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center });
            var b3 = new Border() { BorderThickness = new Thickness(5), BorderBrush = Brushes.Black, Margin = new Thickness(10), Width = 200 };
            first.Children.Add(b3);
            wynik = new TextBox() { Name = "Wynik", FontSize = 40, Padding = new Thickness(10) };
            b3.Child = wynik;
            wynik.KeyDown += Wynik_KeyDown;
            second.HorizontalAlignment = HorizontalAlignment.Center;
            var b4 = new Border() { BorderThickness = new Thickness(5), BorderBrush = Brushes.Black, Margin = new Thickness(10), Width = 200 };
            second.Children.Add(b4);
            var losujButton = new Button() { Content = "Losuj", FontSize = 40};
            losujButton.Click += Losuj_Click;
            b4.Child = losujButton;
            var b5 = new Border() { BorderThickness = new Thickness(5), BorderBrush = Brushes.Black, Margin = new Thickness(10), Width = 200 };
            second.Children.Add(b5);
            var sprawdzButton = new Button() { Content = "Sprawdź", FontSize = 40 };
            sprawdzButton.Click += Sprawdz_Click;
            b5.Child = sprawdzButton;
            obraz = new Image() { Name="Obraz", Source = new BitmapImage(new Uri("grafika/pytanie.png", UriKind.Relative)), Width = 120};
            last.Children.Add(obraz);   
            LosujLiczby();
        }

        private void Losuj_Click(object sender,RoutedEventArgs e)
        {
            LosujLiczby();
        }
        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (wynik.Text.Length > 0 && Information.IsNumeric(wynik.Text) && int.Parse(wynik.Text) == result)
            {
                obraz.Source = new BitmapImage(new Uri("grafika/dobrze.png", UriKind.Relative));
            }
            else
            {
                obraz.Source = new BitmapImage(new Uri("grafika/zle.png", UriKind.Relative));
            }
        }
        private void Wynik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Sprawdz_Click(sender, e);
            }
        }
        public void LosujLiczby()
        {
            int l1 = random.Next(1, 11);
            int l2 = random.Next(1, 11);
            result = l1 * l2;
            liczba1.Text = l1.ToString();
            liczba2.Text = l2.ToString();
            wynik.Focus();
            wynik.Clear();
            obraz.Source = new BitmapImage(new Uri("grafika/pytanie.png", UriKind.Relative));
        }
    }
}