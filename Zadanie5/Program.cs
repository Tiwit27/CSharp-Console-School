namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Komputer komputer = new();
                komputer.PodajParametryKomputera();
                komputer.WypiszParametryKomputera();
                Console.WriteLine("Jeśli chcesz utworzyć nowy komputer wciśnij 1. Jeśli nie, wciśnij cokolwiek");
                char x = Console.ReadKey().KeyChar;
                Console.Clear();
                if(x != '1')
                {
                    break;
                }
            }
            
        }
    }
}
