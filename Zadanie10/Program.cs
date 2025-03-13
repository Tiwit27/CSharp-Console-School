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
                    f.WyswietlBoki();
                    if(f is Trojkat)
                    {
                        if(!((Trojkat)f).IsGood())
                        {
                            Console.WriteLine("Nie da się zbudować takiego trójkąta");
                            Console.WriteLine("");
                            continue;
                        }
                    }
                    Console.WriteLine("Pole: " + Math.Round(f.Pole(),2));
                    Console.WriteLine("Obwod: " + Math.Round(f.Obwod(),2));
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
