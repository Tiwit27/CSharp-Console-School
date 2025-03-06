namespace Lekcja20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zwierzęta z polimorfizmem");
            Zwierze zwierze1 = new Zwierze();
            Zwierze kot1 = new Kot();
            Zwierze pies1 = new Pies();
            Zwierze krowa1 = new Krowa();

            zwierze1.DajGlos();
            zwierze1.Pokarm();
            zwierze1.Pozytek();
            kot1.DajGlos();
            kot1.Pokarm();
            kot1.Pozytek();
            pies1.DajGlos();
            pies1.Pokarm();
            pies1.Pozytek();
            krowa1.DajGlos();
            krowa1.Pokarm();
            krowa1.Pozytek();
            Informacja(krowa1);
            
            Console.WriteLine("---------------------------");

            List<Zwierze> zwierzeta = new List<Zwierze>();

            zwierzeta.Add(kot1);
            zwierzeta.Add(pies1);
            zwierzeta.Add(krowa1);
            zwierzeta.Add(new Kot());
            zwierzeta.Add(new Pies());
            zwierzeta.Add(new Krowa());

            foreach (var z in zwierzeta)
            {
                Informacja(z);
            }
        }

        static public void Informacja(Zwierze z)
        {
            Console.WriteLine($"Info o {z.GetType().Name}");
            z.DajGlos();
            z.Pokarm();
            z.Pozytek();
            if(z is Kot)
            {
                ((Kot)z).OKocie();
            }
            Console.WriteLine("--------------------------");
        }
    }
}
