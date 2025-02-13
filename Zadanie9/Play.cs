using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    internal class Play
    {
        static string[] players = new string[2];
        static int whichPlayer;
        static char[] characters = { 'X', 'O' };
        static char[,] board = new char[3, 3];
        public static void StartPlay()
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '*';
                }
            }
            Console.Clear();
            Console.WriteLine("Podaj nazwę pierwszego gracza: ");
            players[0] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj nazwę drugiego gracza: ");
            players[1] = Console.ReadLine();
            Console.Clear();
            try
            {
                NextMove(0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void NextMove(int whichPlayer)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine($"Ruch gracza {players[whichPlayer]}");
                    Console.WriteLine();
                    Show();
                    Console.Write("\nPodaj rząd: ");
                    var column = int.Parse(Console.ReadKey().KeyChar.ToString());
                    if (column > 3 || column < 1)
                    {
                        throw new Exception("Błędny rząd");
                    }
                    Console.Write("\nPodaj kolumnę: ");
                    var row = int.Parse(Console.ReadKey().KeyChar.ToString());
                    if (row > 3 || row < 1)
                    {
                        throw new Exception("Błędna kolumna");
                    }
                    if (board[column - 1, row - 1] != '*')
                    {
                        throw new Exception("To pole jest już zajęte");
                    }
                    board[column - 1, row - 1] = characters[whichPlayer];
                    if (Check(column, row) == 0)
                    {
                        if (whichPlayer == 1)
                        {
                            whichPlayer = 0;
                        }
                        else
                        {
                            whichPlayer = 1;
                        }
                        Console.Clear();
                        NextMove(whichPlayer);
                    }
                    else if(Check(column, row) == 2)
                    {
                        Console.Clear();
                        Show();
                        Console.WriteLine("Remis!");
                        Console.ReadKey();
                        Program.Main([]);
                    }
                    else
                    {
                        Console.Clear();
                        Show();
                        Console.WriteLine("Wygrał gracz: " + players[whichPlayer]);
                        Console.ReadKey();
                        Program.Main([]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public static int Check(int col, int row)
        {
            for(int i = 0; i < board.GetLength(0);i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i, j] != characters[whichPlayer])
                    {
                        break;
                    }
                    if(j == 2)
                    {
                        return 1;
                    }
                }
            }
            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[j, i] != characters[whichPlayer])
                    {
                        break;
                    }
                    if (j == 2)
                    {
                        return 1;
                    }
                }
            }
            for(int i = 0, j = 0; i < board.GetLength(0); i++, j++)
            {
                if (board[i, j] != characters[whichPlayer])
                {
                    break;
                }
                if (j == 2)
                {
                    return 1;
                }
            }
            for (int i = 0, j = 2; i < board.GetLength(0); i++, j--)
            {
                if (board[i, j] != characters[whichPlayer])
                {
                    break;
                }
                if (j == 0)
                {
                    return 1;
                }
            }
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == '*')
                    {
                        return 0;
                    }
                }
                if(i == 2)
                {
                    return 2;
                }
            }
            return 0;
        }
        static void Show()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("    ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
