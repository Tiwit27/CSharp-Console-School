using System.Text.RegularExpressions;

namespace Zadanie6
{
    internal class Program
    {
        /*sprawdz poprawność danych wprowadzonych przez użytkownika
        1. kod pocztowy
        2. email
        3. adres strony internetowej
        4. numer telefonu (kierunkowy opcjonalny min 1 max 4)
        */
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Podaj kod pocztowy: ");
                string kodPocztowy = Console.ReadLine();
                if(Regex.IsMatch(kodPocztowy, "^\\d{2}-\\d{3}$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Błędny kod pocztowy, powinien wyglądać w taki sposób: XX-XXX");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
