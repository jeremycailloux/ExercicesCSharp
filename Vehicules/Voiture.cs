using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    public class Voiture : Vehicule
    {

        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {
            //on appel les paramètres du constructeur de vehicule avec base  
        }

        public Voiture(string nom, decimal prix) : base (nom, prix)
        {
            
        }

        public override string Description => "Je suis une voiture \r\n" + base.Description; //on redéfinit la fonction virtuelle qui est dans l'ancêtre vehicule
    }
}
