using System;
using System.IO;
using System.Text;

namespace Météo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                string[] file = File.ReadAllLines("..\\..\\..\\DonnéesMétéoParis.txt", Encoding.UTF8);
                RelevéMensuel[] relevéMensuels = new RelevéMensuel[file.Length - 1];

                for (int i = 1; i < file.Length; i++)
                {
                    relevéMensuels[i] = new RelevéMensuel(file[i].Split('\t'));
                }

                Console.WriteLine(@"Mois    | T° min | T° max | Précip (mm) | Ensol (H)
----------------------------------------------------");

                foreach (var item in relevéMensuels)
                {
                    Console.WriteLine(item.ToString());
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
