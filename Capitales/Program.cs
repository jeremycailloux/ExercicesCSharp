using System;

namespace Capitales
{
    class Program
    {
 		static string[] pays = new string[] {
			"Albanie",
			"Allemagne",
			"Andorre",
			"Autriche",
			"Belgique",
			"Biélorussie",
			"Bosnie-Herzégovine",
			"Bulgarie",
			"Chypre",
			"Croatie",
			};

		static string[] capitales = new string[] {
			"Tirana",
			"Berlin",
			"Andorre-la-Vieille",
			"Vienne",
			"Bruxelles",
			"Minsk",
			"Sarajevo",
			"Sofia",
			"Nicosie",
			"Zagreb",
			};      
		
        static void Main(string[] args)
        {
			//Jouer();
			Jouer2();
			Console.ReadLine();
        }



		// Pose 10 questions dans l'ordre
		static void Jouer()
		{
			int bonnesRep = 0;
			bool continuer = true;

			while (continuer)
			{
				for (int i = 0; i < pays.Length; i++)
				{
					Console.WriteLine("\nQuelle est la capitale de {0} ?", pays[i]);
					string rep = Console.ReadLine(); //Pourquoi la varible rep n'est pas n'est pas déclarée ou initiée ou appelée avant comme pour int et bool
					if (rep == capitales[i])
					{
						Console.WriteLine("Bravo !");
						bonnesRep++;
					}
					else
						Console.WriteLine("Mauvaise réponse. La réponse était : {0}", capitales[i]);
				}

				Console.WriteLine("\n{0} bonnes réponses", bonnesRep);
				Console.WriteLine("Voulez-vous rejouer (O/N) ?");
				string rep2 = Console.ReadLine(); //Pourquoi la varible rep2 n'est pas n'est pas déclarée ou initiée ou appeléeavant comme pour int et bool
				if (rep2 == "O" || rep2 == "o")
					Console.Clear();
				else
				{
					continuer = false;
					Console.WriteLine("Merci d'avoir joué");
				}
			}
		}

		//Pose 10 questions dans le désordre
		static void Jouer2()
		{

			Console.Clear();
			Console.WriteLine("Appuyer sur Echap pour arrêter le jeu");

			Random rd = new Random();
			bool continuer = true;

			while (continuer == true)
			{
				int i = rd.Next(pays.Length-1);
				PoserQuestion(i);

				ConsoleKeyInfo touche = Console.ReadKey();
				if (touche.Key == ConsoleKey.Escape)
					continuer = false;
			}

		}

		public static void PoserQuestion(int i) //Pourquoi la méthode poser question n'est pas appelée dans le Main? Pourquoi void?
		{
			Console.WriteLine("\nQuelle est la capitale de {0} ?", pays[i]);
			string rep = Console.ReadLine();
			if (rep == capitales[i])
				Console.WriteLine("Bravo !");
			else
				Console.WriteLine("Mauvaise réponse. La réponse était : {0}", capitales[i]);
		}
	}
}
