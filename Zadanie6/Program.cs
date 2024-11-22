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
            string[] dane = new string[4]; 
            dane[0] = Check("kod pocztowy", "^\\d{2}-\\d{3}$", "Błędny kod pocztowy, powinien wyglądać w taki sposób: XX-XXX");
            dane[1] = Check("adres email", "^[!-z]{2,}@[!-z]{1,}\\.[A-z]{2,4}$", "Błędny adres email, powinien wyglądać w taki sposób: XXXXXXX@XXXX.XX");
            dane[2] = Check("adres strony internetowej", "^((http)s*:\\/\\/)*[0-z]+\\.[A-z]{1,4}[!-z]*$", "Błędny adres strony internetowej, powinien wyglądać w taki sposób: XXXXXXXXXXXX.XX lub opcjonalnie https://XXXXXXXX.XX");
            dane[3] = Check("numer telefonu", "^(\\+\\d\\d)*\\s*(\\d{3})\\s*(\\d{3})\\s*(\\d{3})$", "Błędny numer telefonu, powinien wyglądać w taki sposób: XXX XXX XXX lub opcjonalnie +XX XXX XXX XXX");
            Console.WriteLine($"Wprowadzone dane: \n" +
                $"kod pocztowy: {dane[0]}\n" +
                $"adres email: {dane[1]}\n" +
                $"adres strony internetowej: {dane[2]}\n" +
                $"numer telefonu: {dane[3]}\n");
        }
        static string Check(string nazwa,string regex ,string blad)
        {
            string podanaWartosc;
            while (true)
            {
                Console.WriteLine($"Podaj {nazwa}: ");
                podanaWartosc = Console.ReadLine();
                if (Regex.IsMatch(podanaWartosc, regex))
                {
                    Console.WriteLine("Poprawny " + nazwa);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(blad);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return podanaWartosc;
        }
    }
}
