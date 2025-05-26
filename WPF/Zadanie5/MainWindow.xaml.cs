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

namespace Zadanie5
{
    public partial class MainWindow : Window
    {
        public bool isClosing = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Przelicz(object sender)
        {
            TextBox tb = ((TextBox)sender);
            if(isClosing)
            {
                goto end;
            }
            try
            {
                if (String.IsNullOrEmpty(tb.Text))
                {
                    tb.Text = 0.ToString();
                }
                double defaultValue = double.Parse(tb.Text);
                switch (tb.Name)
                {
                    case "celcius":
                        if(defaultValue < -273.15)
                        {
                            celcius.Clear();
                            throw new Exception("Przekroczono zero bezwzględne");
                        }
                        fahrenheit.Text = ObliczFahrenheity(defaultValue, tb.Name).ToString();
                        kelvin.Text = ObliczKelviny(defaultValue, tb.Name).ToString();
                        break;
                    case "fahrenheit":
                        if (defaultValue < -459.67)
                        {
                            fahrenheit.Clear();
                            throw new Exception("Przekroczono zero bezwzględne");
                        }
                        celcius.Text = ObliczCelciusze(defaultValue, tb.Name).ToString();
                        kelvin.Text = ObliczKelviny(defaultValue, tb.Name).ToString();
                        break;
                    case "kelvin":
                        if (defaultValue < 0)
                        {
                            kelvin.Clear();
                            throw new Exception("Przekroczono zero bezwzględne");
                        }
                        celcius.Text = ObliczCelciusze(defaultValue, tb.Name).ToString();
                        fahrenheit.Text = ObliczFahrenheity(defaultValue, tb.Name).ToString();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        end:;
        }
        double ObliczCelciusze(double value, string dataType)
        {
            if(dataType == "fahrenheit")
            {
                return Math.Round((value - 32) * 5.0 / 9.0, 2);
            }
            return Math.Round(value - 273.15, 2);
        }
        double ObliczFahrenheity(double value, string dataType)
        {
            if (dataType == "celcius")
            {
                return Math.Round(value * (9.0 / 5.0) + 32,2);
            }
            return Math.Round(value * (9.0 / 5.0) - 459.67,2);
        }
        double ObliczKelviny(double value, string dataType)
        {
            if (dataType == "celcius")
            {
                return Math.Round(value + 273.15,2);
            }
            return Math.Round((value + 459.67) * (5.0 / 9.0),2);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Przelicz(sender);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Przelicz(sender);
            }
        }
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!Char.IsDigit(c) && c != '-')
                {
                    e.Handled = true;
                    break;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isClosing = true;
        }
    }
}