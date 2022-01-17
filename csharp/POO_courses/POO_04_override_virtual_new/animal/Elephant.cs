namespace POO_04_override_virtual_new.animal;

public class Elephant : Animal
{
    public override void Wash()
    {
        Console.WriteLine("L'éléphant est bien lavé, il trompe");
    }

    public override void Eat()
    {
        base.Stocker();
    }

    public override string ToString()
    {
        return "elephant";
    }
}