using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RelevésMeteo
{
    class RelevéMensuel
    {
        public DateTime Mois { get; set; }
        public float TMin { get; set; }
        public float TMax { get; set; }
        public float Précip { get; set; }
        public float Ensol { get; set; }

        public RelevéMensuel(string[] tab)
        {
            Mois = DateTime.Parse(tab[0]);
            TMin = float.Parse(tab[1]);
            TMax = float.Parse(tab[2]); 
            Précip = float.Parse(tab[3]); 
            Ensol = float.Parse(tab[4]); 
        }

        public override string ToString()
        {
            return string.Format("{0:MM/yyyy}|{1,8}|{2,8}|{3,13}|{4,10}", Mois, TMin, TMax, Précip, Ensol);
        }
    }
}
