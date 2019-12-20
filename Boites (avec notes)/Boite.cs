using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{   
    //Questions 1 à 4
    enum Couleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    enum Matieres { Carton, Plastique, Bois, Metal }
    class Boite
    {
        public static int Compteur { get; private set; } //Question 9, c'est une propriété static, commune à toutes les instances
        // Implementation automatique
        public double Hauteur { get; } = 30; //propriétés en lecture seule, sans le set
        /*
         * //Implementation détaillée
        private double Largeur _largeur = 30;
        public double Largeur { get; }
        {
            get { return _largeur; }
        }
        */
        public double Largeur { get; } = 30; //arrivé à la question 6, 7 et 8 on aura un constructeur pour donner des valeurs, on peut donc supprimer ces valeurs
        public double Longueur { get; } = 30;
        public Couleurs Couleur { get; set; } //on définit une propriété en lecture/ecriture
        public Matieres Matiere { get; set; } //on définit une propriété en lecture/ecriture
        public double Volume 
        {
            get
            {
                return Largeur * Hauteur * Longueur;
            }
        }
        
        //Question 5
        public void Etiqueter(string destinataire)
        {

        }

        public void Etiqueter(string destinataire, bool fragile) //on ajoute une etiquette fragile, c'est un autre paramètre qui est un booléen, fragile ou pas
        {
            Etiqueter(destinataire); //on appel la première méthode dans cette deuxième
        }

        //Question 7 et 8
        public Boite(double larg, double longu, double haut)
        {
            Compteur++; //Question 9
            Largeur = larg;
            Longueur = longu;
            Hauteur = haut;
        }

        public Boite(double larg, double longu, double haut, Matieres mat) : this (larg, longu, haut) //on appalle le 1er constructeur en lui transmettant lzs paramètres reçus
        {
            Matiere = mat;
        }
        //question 6

        //Methode static (quand c'est static c'est partagé entre les instances)
        public static bool Compare(Boite b, Boite d)
        {
            if (b.Largeur == d.Largeur && b.Longueur == d.Longueur && b.Hauteur == d.Hauteur && b.Matiere == d.Matiere)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //methode non static ou d'instance (une instance c'est un objet de la classe, ici une boite crée)
        public bool Compare2(Boite b)
        {
            if (b.Hauteur == Hauteur && b.Longueur == Longueur && b.Largeur == Largeur && b.Matiere == Matiere)
            {
                return true;
            }

            else
                return false;
        }

        /*
        Dans la Classe Boite :
        public static bool Compare(Boite b1, Boite b2)
        {
            if (b1.Hauteur == b2.Hauteur
                && b1.Largeur == b2.Largeur
                && b1.Longeur == b2.Longeur
                && b1.Matiere == b2.Matiere)
            {
                return true;
            }
            else return false;
        }

        public bool Compare2(Boite b1)
        {
            if (b1.Hauteur == Hauteur
                && b1.Largeur == Largeur
                && b1.Longeur == Longeur
                && b1.Matiere == Matiere)
            {
                return true;
            }
            else 
                return false;
        }

        Leur utilisation dans Program :
        static void Main(string[] args)
        {
            //Initialisation de 2 objets Boites
            Boite boite1 = new Boite(10, 10, 30, Matieres.Carton);
            Boite boite2 = new Boite(10, 10, 10, Matieres.Carton);

            //Premiere méthode avec 2 objet Boite en paramètre
            if(Boite.Compare(boite1, boite2) == true){
                Console.WriteLine("La Même");
            }
            else Console.WriteLine("Pas la même");

                       
            //Deuxième méthode avec la méthode Compare2 utilisé sur l'objet "boite1" et prenant en paramètre un autre objet boite
            if (boite2.Compare2(boite1))
            {
                Console.WriteLine("La Même");
            }
            else Console.WriteLine("Pas la même");
        }
        */

    }


}
