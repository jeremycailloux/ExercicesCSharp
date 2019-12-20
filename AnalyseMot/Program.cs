using System;

namespace AnalyseMot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Console.WriteLine("Entrez un mot");
			string mot = Console.ReadLine();

			int nbLettres, nbVoy, nbCons;
			nbLettres = CompterLettres(mot, out nbVoy, out nbCons);

			Console.WriteLine("Le mot {0} comporte {1} lettre, dont {2} voyelles et {3} consonnes", 
				mot, nbLettres, nbVoy, nbCons);

			Console.ReadKey();
        }

		public static int CompterLettres(string mot, out int nbVoyelles, out int nbConsonnes)
		{
			mot = mot.ToUpper();
			nbVoyelles = 0;
			for (int c = 0; c < mot.Length; c++)
			{
				if (mot[c] == 'A' || mot[c] == 'E' || mot[c] == 'I' || mot[c] == 'O' || mot[c] == 'U' || mot[c] == 'Y')
					nbVoyelles++;
			}

			nbConsonnes = mot.Length - nbVoyelles;
			return mot.Length;
		}
	}
}
