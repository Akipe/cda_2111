namespace POO_03_writetool;

public class OutilEcriture : IOutil
{
    private int _capaciteEcriture;
    private string _couleur;

    public int CapaciteEcriture
    {
        get { return _capaciteEcriture; }
        protected set { _capaciteEcriture = value; }
    }

    public string Couleur
    {
        get { return _couleur; }
        private set { _couleur = value; }
    }

    private void Ecriture()
    {
        
    }

    public void Utiliser()
    {
        throw new Exception("Not implement");
    }
}