namespace POO_03_writetool;

public class Crayon : OutilEcriture
{
    private bool _pointeDeMineTaillee;

    public bool PointDeMineTaillee
    {
        get { return _pointeDeMineTaillee; }
        private set { _pointeDeMineTaillee = value; }
    }

    public void Tailler()
    {
        if (CapaciteEcriture > 0)
        {
            CapaciteEcriture -= 3;
            
            PointDeMineTaillee = false;
        }
    }

    public void Ecrire()
    {
        if (this.PointDeMineTaillee)
        {
            Random random = new Random();
            int rnd = random.Next(0, 3);
            Console.WriteLine($"J'écris du texte, de couleur {Couleur}.");

            if (rnd == 0)
            {
                PointDeMineTaillee = false;
            }
        }
    }
}