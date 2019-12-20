using System;
using System.IO;

namespace EcritureNote
{
    class Program
    {
        static void Main(string[] args)
        {
            SaisirNote();
        }

        static void SaisirNote()
        {
            Console.WriteLine("Saisissez un texte et un chemin de fichier");
            string text = Console.ReadLine();
            string path = Console.ReadLine();
            EnregistrerNote(text, path); //on appel la fonction EnregistrerNote avec ses paramètres path et text
        }


        static void EnregistrerNote(string text, string path)
        {
            StreamWriter outputFile = null; //il faut appler la biliothèque de classe avec alt + enter
            try
            {
                outputFile = new StreamWriter(path, true);
                outputFile.WriteLine(text);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (outputFile != null) outputFile.Close();
                Console.WriteLine("Le chemin n'éxiste pas.");
            }

            //on remplace le bloc try finally (que l'on isole du code avec /* par un bloc using

            /*
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                outputFile.WriteLine(text);
            }
            */


        }

    }
}
