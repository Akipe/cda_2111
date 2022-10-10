namespace ToutEmbalCorrection.Core
{
    public class Production
    {
        public readonly TypeCaisse type;
        public readonly int quantiteVoulu;
        /// <summary>
        /// Temps pour créer une production en milisecondes.
        /// </summary>
        public readonly int tempsParProduit;

        public double TauxDefautGlobal { get; private set; }
        public double TauxDefautHeure { get; private set; }
        public bool EstDemarre { get; private set; }
        public int Quantite { get; private set; }

        public Production(TypeCaisse type, int quantiteVoulu)
        {
            this.type = type;
            this.quantiteVoulu = quantiteVoulu;
            tempsParProduit = CalcTempsParProduit();

            TauxDefautGlobal = 0;
            TauxDefautHeure = 0;
            EstDemarre = false;
            Quantite = 0;
        }

        public Production(TypeCaisse type) : this(type, 10000)
        {
        }

        public void Demarrer()
        {
            if (EstDemarre)
            {
                return;
            }

            TauxDefautGlobal = 0d;
            TauxDefautHeure = 0d;
            Quantite = 0;

            EstDemarre = true;

            Executer();
        }

        public void Arreter()
        {
            if (!EstDemarre)
            {
                return;
            }

            EstDemarre = false;
        }

        public void Reprendre()
        {
            if (EstDemarre)
            {
                return;
            }

            EstDemarre = true;
        }

        private int CalcTempsParProduit()
        {
            return (int)(36000d / (double)type * 1000d);
        }

        public void Executer()
        {
            if (EstDemarre)
            {
                while (Quantite < quantiteVoulu)
                {
                    if (EstDemarre)
                    {
                        Thread.Sleep(tempsParProduit);
                        ++Quantite;
                    }
                }
            }
        }
    }
}