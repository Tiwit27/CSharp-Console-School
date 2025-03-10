namespace Lekcja22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zwierzeta = new List<Zwierzeta>();
            zwierzeta.Add(new Kot());
            zwierzeta.Add(new Pies());
            zwierzeta.Add(new Krowa());

            foreach(var zwierze in zwierzeta)
            {
                zwierze.PokazTypZwierzecia();
                zwierze.Pokarm();
                zwierze.DajGlos();
                zwierze.Pozytek();
                if(zwierze is Kot)
                {
                    ((Kot)zwierze).OKocie();
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
