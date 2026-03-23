namespace Lekcja29;

public abstract class Zwierze
{
    public abstract void DajGlos();

    public abstract void Pokarm();

    public void KimJestem()
    {
        Console.WriteLine("Jestem zwierzęciem typu " + this.GetType().Name);
    }

    public abstract void Pozytek();

    public virtual void CzyUdomowione()
    {
        Console.WriteLine("Jestem zwierzęciem udomowionym");
    }
}