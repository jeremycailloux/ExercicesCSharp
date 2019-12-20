using System;
using System.IO;
using System.Text;

namespace RelevésMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                

                Console.WriteLine(@"Mois | T° min | T° max | Précip (mm) | Ensol (H)
----------------------------------------------------");

                foreach (var item in DAL.GetRelevésMensuels()) //on appel la methode pour qu'elle renvoit la liste
                {
                    Console.WriteLine(item.ToString()); //on affiche les éléments un par un
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
