using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOO
{
    class MoyenPaiement
    {
        public long NuméroCompte { get; }
        public string NomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }
        public DateTime DateDernierRenouvellement { get; set; }

        public MoyenPaiement(long numéroCompte)
        {
            NuméroCompte = numéroCompte;
        }

        public virtual void Renouveler(DateTime date)
        {
            DateDernierRenouvellement = date;
        }

        public override string ToString()
        {
            return $"Moyen de paiement du comtpe {NuméroCompte} de {NomTitulaire}";
        }
    }
    class Carte:MoyenPaiement
    {
        public int Numéro { get; }
        public DateTime DateExpiration { get; set; }
        public int CodeSecret { get; set; }
        public int Cryptogramme { get; set; }

        public Carte(long numCompte, int numCarte) : base(numCompte)
        {
            Numéro = numCarte;
        }

        public override void Renouveler(DateTime date)
        {
            base.Renouveler(date);
            DateExpiration = DateExpiration.AddYears(2);
        }

        public override string ToString()
        {
            /*string s = base.ToString();
            s += $"Carte N° {Numéro}";
            return s;*/

            // appelle la méthode ToString de la classe de base et concatène le 
            // résultat avec le numéro de la carte
            return base.ToString() + $"\nCarte N° {Numéro}";
        }
    }

    class Chequier:MoyenPaiement
    {
        public string Adresse { get; set; }
        public long NuméroPremierCheque { get; set; }
        public int NbCheques { get; set; }
        public Chequier(long numCompte) :base (numCompte)
        {

        }

        public override void Renouveler(DateTime date)
        {
            base.Renouveler(date);
            NuméroPremierCheque += NbCheques;
        }
    }
}
