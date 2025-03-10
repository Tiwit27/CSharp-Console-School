namespace Zadanie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Figury płaskie
            //Zdefiniuj klasę abstrakcyjną figura na bazie której będziemy budować klasy: prostokąt, trójkąt, koło które zawierają zaimplementowane metody
            //odziedziczone po klasie figura. Metody: Pole, Obwód, WyswietlTyp 

            try
            {
                var figury = new List<Figura>();
                figury.Add(new Trojkat(3, 4, 5));
                figury.Add(new Trojkat(5,4,15));
                figury.Add(new Kolo(5));
                figury.Add(new Kolo(3));
                figury.Add(new Prostokat(5,4));
                figury.Add(new Prostokat(2,10));

                foreach(var f in figury)
                {
                    f.WyswietlTyp();
                    if(f is Trojkat)
                    {

                    }
                    Console.WriteLine("Pole: " + f.Pole());
                    Console.WriteLine("Obwod: " + f.Obwod());
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
