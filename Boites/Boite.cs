using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{   //ici j'ai ajouté une région enumerations, juste plus pratique pas nécessaire
	#region Enumerations 
	public enum Couleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
	public enum Matieres { Carton, Plastique, Bois, Métal }
    #endregion
    class Boite
    {

		//Question 11
		private Etiquette _etiquetteDest;
		private Etiquette _etiquetteFragile;

		// implémentation automatique
		public double Hauteur { get; }

		// Implémentation détaillée
		public double Largeur { get; }

		public double Longueur { get; }

		public Couleurs Couleur { get; set; }

		public Matieres Matiere { get; } = Matieres.Carton;

		public double Volume
		{
			get
			{				
				return Largeur * Hauteur * Longueur;
			}
		}

		public static int Compteur { get; private set; }	// propriété statique

		public Boite(double hauteur, double largeur, double longueur)
		{
			Hauteur = hauteur;
			Largeur = largeur;
			Longueur = longueur;

			Compteur++;
		}

		public Boite(double hauteur, double largeur, double longueur, Matieres matière):
			this(hauteur, largeur, longueur)
		{
			Matiere = matière;
		}
		/// <summary>
		/// Ajoute une étiquette à la boîte
		/// </summary>
		/// <param name="destinataire">Ajouter l'adresse du destinataire</param>
		public void Etiqueter(string destinataire)
		{
			_etiquetteDest = new Etiquette(destinataire, Couleurs.Blanc, Formats.L);
		}
		
		public void Etiqueter(string dest, bool fragile)
		{

			if (fragile == true) 
			{
				_etiquetteFragile = new Etiquette("Fragile", Couleurs.Rouge, Formats.S);
			}
			Etiqueter(dest);

		}

		public void Etiqueter(Etiquette etiquette1, Etiquette etiquette2)
		{
			_etiquetteDest = etiquette1;
			_etiquetteFragile = etiquette2;
		}

		public bool Compare(Boite b)
		{
			if (Hauteur == b.Hauteur && Largeur == b.Largeur && Longueur == b.Longueur
				&& Matiere == b.Matiere)
				return true;
			else
				return false;
		}
		/// <summary>
		/// Compare deux boîtes
		/// </summary>
		/// <param name="b1">boite 1</param>
		/// <param name="b2">boite 2</param>
		/// <returns></returns>True si les dimensions et la matière des boites sont identiques, false si déifférentes
		public static bool Compare(Boite b1, Boite b2)
		{
			if (b1.Hauteur == b2.Hauteur && b1.Largeur == b2.Largeur && b1.Longueur == b2.Longueur
				&& b1.Matiere == b2.Matiere)
				return true;
			else
				return false;
		}

		 
	}
}
