namespace POO_04_override_virtual_new;

public class Zoo
{
    private List<Animal> _animals = new List<Animal>();

    public List<Animal> Animals
    {
        get 
        {
            return _animals;
        }
        set
        {
            _animals = value;
        }
    }

    public void WashAllAnimals()
    {
        Console.WriteLine("On va laver tous les animaux...");
        foreach (Animal animal in Animals)
        {
            Console.Write($"{animal} : ");
            animal.Wash();
        }
    }
    
    public void GiveEatAllAnimals()
    {
        Console.WriteLine("On va donner à manger à tous les animaux...");
        foreach (Animal animal in Animals)
        {
            Console.Write($"{animal} : ");
            animal.Eat();
        }
    }
}