using System;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcul du PGCD de 2 nombres");
            Console.WriteLine("Saisissez un 1er nombre");
            string nombrep = Console.ReadLine(); //déclaration de la variable et on l'initialise avec la valeur saisie par l'utilisateur
            Console.WriteLine("Saisissez un 2ème nombre");
            string nombreq = Console.ReadLine(); //un chiffre est considéré comme une chaîne de caractère quand il est lu via Console.ReadLine
            //quand on déclare une variable, elle a un type et un nom, et elle sera utilisée, sinon elle ne sert à rien
            int p = int.Parse(nombrep); //on crée un vrai nombre en transformant la chaine recu en nombre
            int q = int.Parse(nombreq); //déclaration d'une variable = son affectation
            int nb1 = p;
            int nb2 = q;
            
            while (p !=q)
            {
                if (p > q)
                {
                    p = p - q;
                }

                else q = q - p;
            }

            Console.WriteLine("Le PGCD de " + nb1 + " et " + nb2 + " est " + p);

        }
    }
}
