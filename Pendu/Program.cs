using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jouez au pendu!");

            //--------------------------------------------------------------------------
            // 1. Les étapes ci-desous consistent à faire saisir un mot valide au 1er joueur

            string mot = string.Empty;
            bool motValide = false;
            // Tant que le mot saisi n'est pas valide
            while (!motValide)
            {
                // On fait saisir le mot
                Console.WriteLine("Veuillez saisir un mot entre 3 et 25 lettres sans accent");
                mot = Console.ReadLine();
                // On vérifie son format (appeler la méthode statique VerifierMot)
                try
                {
                    Jeu.VerifierMot(mot);
                    motValide = true;
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                //Console.ReadKey();







            }

            //--------------------------------------------------------------------------
            // 2. les étapes suivantes consistent à faire deviner le mot au 2d joueur

            // On vide l'écran
            Console.Clear();

            // On crée un jeu et on l'initialise avec le mot saisi
            Jeu jeu = new Jeu();
            jeu.InitialiserJeu(mot);

            // Tant que le jeu n'est pas fini
            while (jeu.GetEtatPartie() == EtatsPartie.EnCours)
            {
                // On affiche le dessin et l'état du mot en cours
                Console.WriteLine(jeu.GetDessinPendu());
                Console.WriteLine(jeu.GetMotEnCours());
                // On demande une lettre et on la teste
                Console.WriteLine("Proposez une lettre");
                char lettreProposée = Console.ReadKey().KeyChar;
                
                jeu.TesterLettre(lettreProposée);
                // Console.ReadKey();
                //on utilise readKey plutôt que ReadLine pour ne pouvoir saisir qu'une lettre

                // Si la partie est gagnée, on affiche un message en vert
                if (jeu.GetEtatPartie() == EtatsPartie.Gagnée)
                {
                    Console.WriteLine("Bravo! Vous avez gagné.");
                }
                // Si elle est perdue on affiche un message en rouge avec la solution
                if (jeu.GetEtatPartie() == EtatsPartie.Perdue)
                {
                    Console.WriteLine("Vous avez perdu. Le mot à deviner était : " + jeu.GetMotADeviner());
                    Console.WriteLine($"Vous avez perdu. Le mot à deviner était : { jeu.GetMotADeviner()}"); //Deuxième methode
                    Console.WriteLine("Vous avez perdu. Le mot à deviner était : {0}", jeu.GetMotADeviner());//Troisieme methode

                }
            }

            Console.ReadKey();
        }

    }
}
