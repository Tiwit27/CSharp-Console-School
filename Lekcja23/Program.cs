namespace Lekcja23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Zwierze>();
            lista.Add(new Pies());
            lista.Add(new Pies());
            lista.Add(new Kot());
            lista.Add(new Kot());
            lista.Add(new Krowa());
            lista.Add(new Krowa());

            foreach (var item in lista)
            {
                item.KimJestem();
                item.DajGlos();
                item.Pozywienie();
                Console.WriteLine("");
            }
        }
    }
}
