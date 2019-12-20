using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{

    public enum Formats { XS, S, M, L, XL}
    class Etiquette
    {
        public string Texte { get; set;  }
        public Couleurs Couleur { get; set;  }
        public Formats Format { get; set;  }

        public Etiquette(string texte, Couleurs couleur, Formats format)
        {
            Texte = texte;
            Couleur = couleur;
            Format = format;
        }

        public Etiquette()
        {
            //Constructeur vide qui sert juste à faire marcher l'initialiseur
        }

        //Sinon on cré un initialiseur
        /*
    }
}
