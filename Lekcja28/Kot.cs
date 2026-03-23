namespace Lekcja28;

public class Kot : Zwierze
{
    override public void DajGlos()
    {
        Console.WriteLine("Miau Miau");
    }
    
    override public void Pokarm()
    {
        Console.WriteLine("Kocia karma");
    }
    
    override public void KimJestem()
    {
        base.KimJestem();
        Console.WriteLine("Jestem kotem");
    }
    
    override public void Pozytek()
    {
        Console.WriteLine("Łowie myszy");
    }
}