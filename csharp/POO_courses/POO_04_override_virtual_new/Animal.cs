namespace POO_04_override_virtual_new;

public class Animal
{
    public virtual void Wash()
    {
        Console.WriteLine("L'animal est bien lavé");
    }

    public virtual void Eat()
    {
        Console.WriteLine("L'animal a bien mangé, miam!");
    }
}