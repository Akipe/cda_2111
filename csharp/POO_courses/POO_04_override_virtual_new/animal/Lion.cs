namespace POO_04_override_virtual_new.animal;

public class Lion : Animal
{
    public new void Wash()
    {
        Console.WriteLine("Le lion est bien lavé, il rugis");
    }

    public new void Eat()
    {
        Console.WriteLine("Le lion a bien mangé des animaux");
    }
    
    public override string ToString()
    {
        return "lion";
    }
}