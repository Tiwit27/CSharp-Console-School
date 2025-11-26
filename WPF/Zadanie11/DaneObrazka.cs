using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Zadanie11
{
    class DaneObrazka
    {
        public BitmapImage source;
        public Point pozycja;

        public DaneObrazka(BitmapImage source, Point pozycja)
        {
            this.source = source;
            this.pozycja = pozycja;
        }
    }
}
