
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RelevésMeteo
{
    static class DAL
    {
        public const string chemin = @"..\\..\\..\\DonnéesMétéoParis.txt";

        public static List<RelevéMensuel> GetRelevésMensuels()
        {

            string[] file = File.ReadAllLines(chemin, Encoding.UTF8);
            //RelevéMensuel[] relevéMensuels = new RelevéMensuel[file.Length - 1];

            List<RelevéMensuel> relevés = new List<RelevéMensuel>();
            for (int i = 1; i < file.Length; i++) //on parcours le fichier
            {
                var relevé = new RelevéMensuel(file[i].Split('\t')); //on ajoute chaque ligne de relevé mensuel dans la liste
                
                relevés.Add(relevé);
 
            }

            return relevés; // on retourne le contenu de la liste

        }

        


}
}