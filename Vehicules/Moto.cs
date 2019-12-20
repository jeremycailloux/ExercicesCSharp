using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Moto : Vehicule  //Exercice Etape 4
    {
        public Moto(string nom, int nbRoues, Energies energie) : base(nom, nbRoues, energie) //Alt + Entr sur Moto surligné rouge
        {
            //on génère un constructeur moto ayant les paramètres du constructeur vehicule car dans la classe véhicule on a créé un constructeur avec des paramètres, si ce n'était pas le cas ce ne serait pas nécessaire
        }
        
        public Moto(string nom, decimal prix) : base(nom, prix)
        {
           
        }
        public override string Description => "Je suis une moto  \r\n" + base.Description; //on crée une méthode virtuelle qui appelle la méthode de la classe véhicules qui est alors redéfinie

         
    }


}
