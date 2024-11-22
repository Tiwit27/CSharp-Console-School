using System.Globalization;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int[] PESEL = new int[11];
                    Console.WriteLine("Podaj swój PESEL: ");
                    string value = Console.ReadLine();
                    if(String.IsNullOrEmpty(value) || value.Length != 11)
                    {
                        throw new MyException("Błędny PESEL -> błędna długość");
                    }    
                    for (int i = 0; i < PESEL.Length; i++)
                    {
                        PESEL[i] = value[i] - 48;
                    }
                    int dzien = int.Parse(PESEL[4].ToString() + PESEL[5].ToString());
                    int miesiac;
                    int rok;
                    if (PESEL[2] % 2 == 1)
                    {
                        if (PESEL[3] > 2)
                        {
                            throw new MyException("Błędny PESEL -> błędny miesiąc urodzenia");
                        }
                        miesiac = PESEL[3] + 10;
                    }
                    else
                    {
                        miesiac = PESEL[3];
                    }
                    switch(PESEL[2])
                    {
                        case 8:
                        case 9:
                            {
                                rok = 1800 + PESEL[0] + PESEL[1];
                                break;
                            }
                        case 0:
                        case 1:
                            {
                                rok = 1900 + PESEL[0] + PESEL[1];
                                break;
                            }
                        case 2:
                        case 3:
                            {
                                rok = 2000 + PESEL[0] + PESEL[1];
                                break;
                            }
                        case 4:
                        case 5:
                            {
                                rok = 2100 + PESEL[0] + PESEL[1];
                                break;
                            }
                        case 6:
                        case 7:
                            {
                                rok = 2200 + PESEL[0] + PESEL[1];
                                break;
                            }
                        default:
                            {
                                throw new MyException("Błąd");
                            }
                    }
                    if(DateTime.DaysInMonth(rok, miesiac) < dzien)
                    {
                        throw new MyException("Błędy PESEL -> zła data urodzenia");
                    }
                    int cyfraKontrolna = 0;
                    int[] mnoznik = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                    for(int i = 0; i < PESEL.Length - 1; i++)
                    {
                        cyfraKontrolna += (PESEL[i] * mnoznik[i]) % 10;
                    }
                    cyfraKontrolna = 10 - (cyfraKontrolna % 10);
                    if (PESEL[PESEL.Length - 1] != cyfraKontrolna)
                    {
                        throw new MyException("Błędny PESEL -> zła cyfra kontrolna");
                    }
                    else
                    {
                        Console.WriteLine("Poprawny PESEL");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (MyException)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
