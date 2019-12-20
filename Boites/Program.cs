using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b1 = new Boite(10, 12, 13);
            Boite b2 = new Boite(45, 17, 23, Matieres.Bois);
            Boite b3 = new Boite(45, 17, 23, Matieres.Bois);
            Boite b4 = new Boite(45, 17, 23, Matieres.Carton); //Question 11
            Boite b5 = new Boite(30, 40, 50, Matieres.Plastique);
            Etiquette e1 = new Etiquette { Texte = "Robert", Couleur = Couleurs.Blanc, Format = Formats.L};


            bool res1 = b1.Compare(b2); // appel méthode d'instance
            bool res2 = Boite.Compare(b2, b3);  // appel méthode statique

            Console.WriteLine("Il y a {0} boîtes" , Boite.Compteur);

            Console.ReadKey();

            b4.Etiqueter("Bernard", true);
            Console.WriteLine(b4);

            
        }
    }
}
