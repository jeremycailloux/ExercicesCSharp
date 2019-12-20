using System;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Carte carte1 = new Carte(1111, 456465465);
            carte1.CodeSecret = 1234;
            carte1.Cryptogramme = 456;
            carte1.DateExpiration = new DateTime(2021, 12, 31);
            carte1.NomTitulaire = "toto";
            carte1.Renouveler(DateTime.Today);
            Console.WriteLine(carte1.ToString());

            CompteBancaire cb1 = new CompteBancaire(4566542123);


            Carte carte2 = new Carte(2222, 56456) { CodeSecret = 456, Cryptogramme = 456 };

            // Polymorphisme : on stocke dans une variable du type ancêtre une instance de classe dérivée
            MoyenPaiement carte3 = new Carte(222, 123456);

            // Si on veut accéder aux membres de la classe dérivée, il faut transtyper la variable
            if (carte3 is Carte)
            {
                Carte c = (Carte)carte3;
            }

            MoyenPaiement chequier1 = new Chequier(2222);

            DateTime dt = new DateTime(2019, 11, 15);
            CompteBancaire cb2 = new CompteBancaire(9996521, dt, carte2);
             
            cb2.Créditer(123);
            cb2.Créditer(456, "virement salaire");
                      
            Console.WriteLine("Solde du compte {0} : {1}", cb2.Numéro, cb2.Solde);
            Console.WriteLine("Dernière opération : {0}", cb2.Description);
            Console.WriteLine("Numéro de la carte associé au compte {0} : {1}", cb2.Numéro, cb2.CB.Numéro); 

            int cpt = CompteBancaire.Compteur;  // Utilisation d'une propriété statique
            Console.WriteLine("{0} comptes bancaires ont été créés", cpt);


            Console.ReadKey();
        }
    }

}
