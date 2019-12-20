using System;

namespace TriTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[5] { 7, 2, 5, 10, 8 };

            Console.WriteLine("Tableau initial : ");
            foreach (int item in tableau)
            {
                Console.WriteLine($"{item} |");
            }

            SortTable(tableau);

            Console.WriteLine("Tableau initial : ");
            foreach (int item in tableau)
            {
                Console.WriteLine($"{item} |");
            }
        }

        static int[] SortTable(int[] tableToSort)
        {
            //Création de la variable temporaire
            int temp;
            //Création du booléen permuté
            bool permutated = true;

            //Tant que permuté est vrai, effectuer le contenu de la boucle

            while (permutated)
            {
                //Initialiser permuté sur false, afin de le repasser en true SI une des valeurs est permutée lors
                // du parcours du tableau
                permutated = false;

                //Parcourir le tableau
                for (int i = 0; i < tableToSort.Length - 1; i++)
                {
                    //Comparer la valeur i du tableau à la valeur i + 1
                    //Si i+1 est plus petit, les échanger
                    if (tableToSort[i] > tableToSort[i + 1])
                    {
                        //Passer dans la variable temporaire la valeur 1 du tableau
                        temp = tableToSort[i];
                        //Assigner, à la place de la valeur 1, la valeur 2
                        tableToSort[i] = tableToSort[i + 1];
                        //Assigner, à la place de la valeur 2, le contenu de la variable temporaire
                        tableToSort[i + 1] = temp;
                        //Passer permuté à true, afin d'indiquer qu'un changement a été fait et qu'il faut
                        //repasser encore au moins une fois
                        permutated = true;
                    }
                }
            }

            return tableToSort;
        }
    }
}
