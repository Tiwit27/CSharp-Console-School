﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Dysk
    {
        int pojemnosc;
        string Typ {  get; set; }
        int Pojemnosc
        {
            get { return pojemnosc; }
            set 
            { 
                if (value <= 0)
                { 
                    pojemnosc = 32; 
                }
                else 
                { 
                    pojemnosc = value; 
                } 
            }
        }
        string Interfejs { get; set; }
        string Format { get; set; }
        internal void PodajParametry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PARAMETRY DYSKU");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj typ dysku: ");
            Typ = Console.ReadLine();
            Console.Write("Podaj pojemność dysku: ");
            Pojemnosc = int.Parse(Console.ReadLine());
            Console.Write("Podaj interfejs dysku: ");
            Interfejs = Console.ReadLine();
            Console.Write("Podaj format dysku: ");
            Format = Console.ReadLine();
            Console.WriteLine("");
        }
        internal void WypiszParametry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Dysk: \n");
            Console.ResetColor();
            Console.WriteLine(
                $"Typ: {Typ}\n" +
                $"Pojemność: {Pojemnosc} GB\n" +
                $"Interfejs: {Interfejs}\n" +
                $"Format: {Format}\n");
        }
    }
}
