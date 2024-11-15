using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Zasilacz
    {
        uint moc;
        uint Moc
        {
            get { return moc; }
            set
            {
                if(value < 100)
                {
                    moc = 100;
                }
                else
                {
                    moc = value;
                }
            }
        }
        string Certyfikat {  get; set; }
        string Marka { get; set; }
        string Standard { get; set; }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY ZASILACZA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj markę zasilacza: ");
            Marka = Console.ReadLine();
            Console.Write("Podaj certyfikat zasilacza: ");
            Certyfikat = Console.ReadLine();
            Console.Write("Podaj standard zasilacza: ");
            Standard = Console.ReadLine();
            Console.Write("Podaj moc zasilacza: ");
            Moc = uint.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Zasilacz \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Marka: {Marka}\n" +
                $"Moc: {Moc} W\n" +
                $"Certyfikat: {Certyfikat}\n" +
                $"Standard: {Standard}\n");
        }

    }
}
