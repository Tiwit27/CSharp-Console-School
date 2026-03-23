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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie13
{
    public partial class EmptySlot : UserControl
    {
        public string defaultText;
        public EmptySlot()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return textBlock.Text; }
            init { textBlock.Text = value; defaultText = value; }
        }

        public string ImageSource
        {
            get { return (string)image.Source.ToString(); }
        }

        public void Reset()
        {
            image.Source = null;
            textBlock.Text = defaultText;
        }
        public void Update(string imageSource)
        {
            image.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            textBlock.Text = "";
        }
    }
}
