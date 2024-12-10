using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16
{
    internal class Tablica
    {
        internal static void WyswietlTablice(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i],4}");
            }
        }
        internal static void WyswietlTabliceForeach(int[] tab)
        {
            foreach (int i in tab)
            {
                Console.Write(i);
            }
        }
        internal static void WypelnijTablice(int[] tab, int ileLiczb)
        {
            Random random = new();
            for(int i = 0;i < ileLiczb;i++)
            {
                tab[i] = random.Next(100);
            }
        }
    }
}
