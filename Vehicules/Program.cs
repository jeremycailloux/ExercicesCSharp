using System;
using System.Collections.Generic;

namespace Vehicules
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique }
    class Program
    {

   
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("Toyota", Energies.Electrique);
            Console.WriteLine(voiture.Nom);
            Console.WriteLine(voiture.Energie);
            Console.WriteLine(voiture.NbRoues);
            Console.WriteLine(voiture.Description); //Etape 3
            //Etape 4
            Vehicule voiture2 = new Voiture("Toyota", Energies.Electrique);//on stock une instance de voiture dans une variable du type de la classe ancêtre
            Vehicule moto = new Moto("Suzuki", 2, Energies.Essence); //ca c'est le polymorphisme (vior définition)            
            Console.WriteLine(voiture2.Description);
            Console.WriteLine(moto.Description);

            //listes de vehicules
            Voiture megane = new Voiture("Megane", 19000);
            Moto intruder = new Moto("Intruder", 13000);
            Voiture enzo = new Voiture("Enzo", 380000);
            Moto yamahaXJR1300 = new Moto("Yamaha XJR1300", 11000);

            Console.WriteLine("\nLe classement dans la liste1");
            SortedList<string, Vehicule> liste1 = new SortedList<string, Vehicule>();
            liste1.Add(megane.Nom, megane);
            liste1.Add(intruder.Nom, intruder);
            liste1.Add(enzo.Nom, enzo);
            liste1.Add(yamahaXJR1300.Nom, yamahaXJR1300);

            foreach (var item in liste1)
            {
                Console.WriteLine(item.Key + ":" + item.Value.Prix);
            }
            //La liste est triée par clé ou Key
            //deuxieme liste
            Console.WriteLine("\nLe classement dans la liste2");
            SortedList<Vehicule, string> liste2 = new SortedList<Vehicule, string>();
            liste2.Add(megane, megane.Nom);
            liste2.Add(intruder, intruder.Nom);
            liste2.Add(enzo, enzo.Nom);
            liste2.Add(yamahaXJR1300, yamahaXJR1300.Nom);

            foreach (var item in liste2)
            {
                Console.WriteLine(item.Value + ":" + item.Key.Prix);
            }
            //La liste est triée selon la clé/Key grâce à la méthode CompareTo

            string[] listevehicules = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" }; //Etape 6
            foreach (var item in listevehicules)
            {
                if (liste1.ContainsKey(item))
                {
                    Console.WriteLine(liste1[item].Nom + ":" + liste1[item].Prix);  
                }
            }
        }
    }
}
