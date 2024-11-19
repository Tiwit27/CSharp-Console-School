using System.Text.RegularExpressions;

namespace Lekcja13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wyrażenia regularne
            string text = "asbcabcaaabcaaab";
            string regexValue = "ab+c";
            Regex regex = new(regexValue);

            if(regex.IsMatch(text))
            {
                Console.WriteLine(regex.Match(text));
            }
            else
            {
                Console.WriteLine("Tekst nie pasuje do wzorca");
            }

            Console.WriteLine("Wszystkie wyszukane pasujące fragmenty");
            foreach(var szukane in Regex.Matches(text,regexValue))
            {
                Console.WriteLine(szukane);
            }
            Console.ReadKey();
        }
    }
}
