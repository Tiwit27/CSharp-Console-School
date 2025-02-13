namespace Zadanie9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("MENU:");
                    Console.WriteLine("1. Graj");
                    Console.WriteLine("2. Zakończ grę");
                    var choose = Console.ReadKey();
                    if(choose.KeyChar == '2')
                    {
                        Environment.Exit(0);
                    }
                    if(choose.KeyChar != '1')
                    {
                        throw new Exception("Nie ma takiego wyboru!");
                    }
                    Play.StartPlay();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
