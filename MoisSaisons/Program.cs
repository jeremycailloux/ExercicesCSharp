using System;

namespace MoisSaisons
{
    [Flags]
    enum Mois { aucun = 0, Janvier = 1, Février = 2, Mars = 4, Avril = 8, Mai = 16,
    Juin = 32, Juillet = 64, Aout = 128, Septembre = 256, Octobre = 512, Novembre = 1024, Decembre = 2048 }

    [Flags]
    enum Saisons { aucun = 0, Hiver =  1, Printemps = 2, Ete = 4, Automne = 8}
    class Program
    {
        static void Main(string[] args)
        {
            Mois m = Mois.Juin;
            Saisons sais = SaisonsDuMois(m);
            Console.WriteLine("Saison(s) du mois {0} : {1}", m, sais);

            /*for (int i = 1; i < (int)Mois.Decembre; i*=2)
            {
                Saisons sais = SaisonsDumois((Mois)i);
                Console.WriteLine("Saison(s) du mois {0} : {1}", (Mois)i, sais);
            }*/
        }

        public static Saisons SaisonsDuMois(Mois m)
        {
            Mois moisHiver = Mois.Decembre | Mois.Janvier | Mois.Février | Mois.Mars;
            Mois moisPrintemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois moisEte = Mois.Juin | Mois.Juillet | Mois.Aout | Mois.Septembre;
            Mois moisAutomne = Mois.Septembre | Mois.Octobre | Mois.Novembre | Mois.Decembre;

            Saisons sais = Saisons.aucun;

            if ((m & moisHiver) == m) sais |= Saisons.Hiver;
            if ((m & moisPrintemps) == m) sais |= Saisons.Printemps;
            if ((m & moisEte) == m) sais |= Saisons.Ete;
            if ((m & moisAutomne) == m) sais |= Saisons.Automne;

            return sais;
        }

    }
}
