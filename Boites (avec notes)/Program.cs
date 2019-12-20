using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b = new Boite(30, 30, 30, Matieres.Carton); //b est l'instance de l'objet
            Boite d = new Boite(40, 50, 50, Matieres.Metal);
            Boite e = new Boite(40, 50, 50, Matieres.Metal);
            Console.WriteLine(Boite.Compteur); //Question 9

            //Appel methode static
            Console.WriteLine(Boite.Compare(b, d)); //on fait appel à la fonction compare et on lui passe en paramètre les instances de mes objets boite
            Console.WriteLine(Boite.Compare(d, e)); //on fait appel à la fonction compare

            //Appel methode non static ou d'instance
            Console.WriteLine(b.Compare2(d)); 
            Console.WriteLine(d.Compare2(e));
            Console.ReadKey();
        }
    }
}
