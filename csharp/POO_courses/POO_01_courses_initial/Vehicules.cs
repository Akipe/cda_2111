using System.Text;

namespace Vehicules
{
    public class Voiture
    {
        private string _proprietaire;
        private string _couleurv1;
        private string _couleurv2;
        private string _couleurv3;
        private int _poids;
        private int _puissance;
        private int _reservoir;
        private int _vitesse;
        private bool _moteurAllume;
        private int _jaugeEssence;

        public int JaugeEssence
        {
            get => _jaugeEssence;
            set {
                if (_jaugeEssence > Reservoir)
                {
                    Reservoir = 0;
                }
                else
                {
                    Reservoir = _jaugeEssence;
                }
            }
            
            
        }

        public bool MoteurAllume
        {
            get => _moteurAllume;
            set => _moteurAllume = value;
        }

        public void Deplacer(int vitesse)
        {
            if (MoteurAllume)
            {
                Vitesse = vitesse;
            }
        }

        // Constructeur
        public Voiture()
        {
            this.Poids = 500;
            this.Couleurv2 = "bleu";
        }
        
        public Voiture(string _proprietaire)
        {
            this._proprietaire = _proprietaire;
            this._couleurv1 = "bleu";
            this._couleurv2 = _couleurv1;
            this._couleurv3 = _couleurv1;
            this._poids = 500;
            this._puissance = 200;
            this._reservoir = 30;
            this._vitesse = 0;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append($"Ma voiture de {Proprietaire} est {Couleurv2}\n");
            result.Append($"Poids: {Poids}, ");
            result.Append($"Puissance: {Puissance}, ");
            result.Append($"Moteur allumé: {MoteurAllume}, ");
            result.Append($"Vitesse: {Vitesse}");
            
            return result.ToString();
        }

        public string Proprietaire
        {
            get => _proprietaire;
            set => _proprietaire = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public int Poids
        {
            get => _poids;
            set => _poids = value;
        }

        public int Puissance
        {
            get => _puissance;
            set => _puissance = value;
        }

        public int Reservoir
        {
            get => _reservoir;
            set => _reservoir = value;
        }

        public int Vitesse
        {
            get => _vitesse;
            set => _vitesse = value;
        }

        // Création automatique des assesseur et mutateur
        public string Couleurv1 { get; set; }

        public string Couleurv2
        {
            get { return this._couleurv2; }
            set { this._couleurv2 = value; }
        }

        public string GetCouleurv3()
        {
            return this._couleurv3;
        }

        public void SetCouleurv3(string value)
        {
            _couleurv3 = value;
        }
    }
}

