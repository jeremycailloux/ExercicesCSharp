using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Vehicules
{
    public class Vehicule : IComparable<Vehicule> //on dérive la classe vehicule de 
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energie { get; }
        public decimal Prix { get; }

        public virtual string Description
        {

            get
            {
               return "Véhicule " + Nom + " roule sur " + NbRoues + " roues et à l’énergie " + Energie;
               //return $"Véhicule {Nom} roule sur {NbRoues} roues et à l’énergie {Energie}";
            }

        }

        public Vehicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }

        public Vehicule(string nom, decimal prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public int CompareTo([AllowNull] Vehicule other) //ne pas tenir compte de l'attribut entre crochets, pas encore vu
        {
            if (Prix < other.Prix) return -1;  
            if (Prix == other.Prix) return 0;
            return +1;

            //
            // Résumé :
            //     Compares the current instance with another object of the same type and returns
            //     an integer that indicates whether the current instance precedes, follows, or
            //     occurs in the same position in the sort order as the other object.
            //
            // Paramètres :
            //   other:
            //     An object to compare with this instance.
            //
            // Retourne :
            //     A value that indicates the relative order of the objects being compared. The
            //     return value has these meanings: Value Meaning Less than zero This instance precedes
            //     other in the sort order. Zero This instance occurs in the same position in the
            //     sort order as other. Greater than zero This instance follows other in the sort
            //     order.
        }
    }
}
