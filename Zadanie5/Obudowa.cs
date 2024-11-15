using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Obudowa
    {
        uint wentylatory;
        string Producent {  get; set; }
        string Nazwa { get; set; }
        uint Wentylatory { get; set; }
        string Kolor {  get; set; }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY OBUDOWY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj producenta obudowy: ");
            Producent = Console.ReadLine();
            Console.Write("Podaj nazwę obudowy: ");
            Nazwa = Console.ReadLine();
            Console.Write("Podaj ilośc wbudowanych wentylatorów: ");
            Wentylatory = uint.Parse(Console.ReadLine());
            Console.Write("Podaj kolor obudowy: ");
            Kolor = Console.ReadLine();
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Obudowa: \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Producent: {Producent}\n" +
                $"Nazwa: {Nazwa}\n" +
                $"Wentylatory: {Wentylatory}\n" +
                $"Kolor: {Kolor}\n");
        }
    }
}
