using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zadanie3
{
    public partial class Kalkulator : Window
    {
        public IFigura Figura { get; set; }
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<double> values = new List<double>();
            try
            {
                for (int i = 1; i < pola.Children.Count; i += 2)
                {
                    var liczba = double.Parse(((TextBox)pola.Children[i]).Text);
                    if(liczba <= 0)
                    {
                        throw new Exception();
                    }
                    values.Add(liczba);
                }
                var pole = Math.Round(Figura.ObliczPole(values), 2);
                p.Text = $"P = {pole}";
                var objetosc = Math.Round(Figura.ObliczObjetosc(values), 2);
                v.Text = $"V = {objetosc}";
            }
            catch(Exception ex)
            {
                for (int i = 1; i < pola.Children.Count; i += 2)
                {
                    ((TextBox)pola.Children[i]).Text = "";
                }
                values.Clear();
                p.Text = "P = ?";
                v.Text = "V = ?";
            }
        }
    }
}
