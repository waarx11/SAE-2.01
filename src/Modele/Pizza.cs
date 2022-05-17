using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Représente une Pizza
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Nom de la pizaa
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        private string nom;

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public int Quantité { get => quantité; set => quantité = value; }
        private int quantité = 1;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Description { get => description; set => description = value; }
        private string description;

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string Image { get => image; set => image = value; }
        private string image;

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public int Prix { get => prix; set => prix = value; }
        private int prix;

        /// <summary>
        /// Liste des ingredient qui constitue la pizza
        /// </summary>
        private List<Ingredients> ListIngredient = new List<Ingredients> {(Ingredients)53, (Ingredients)0 };
        public List<Ingredients> listIngredient { get => ListIngredient; set => ListIngredient = value; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de cette pizza</param>
        /// <param name="description">Description de cette pizza</param>
        /// <param name="image">Image de cette pizza</param>
        /// <param name="prix">Prix de cette pizza</param>

        public Pizza(string nom, string description, string image, List<Ingredients> lIng, int prix=12)
        {
            if(string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(image))
            {
                throw new ArgumentException("Une pizza doit avoir au moins un nom, une description et une image");
            }
            Nom =nom;
            Description = description;
            Image = image;
            Prix = prix;
            foreach (Ingredients Ingre in lIng)
            {
                if (Ingre == (Ingredients)53 || Ingre == (Ingredients)54 || Ingre == (Ingredients)55)
                {
                    listIngredient.Remove((Ingredients)53);
                    listIngredient.Remove((Ingredients)54);
                    listIngredient.Remove((Ingredients)55);
                    listIngredient.Add(Ingre);
                }
                else if (Ingre == (Ingredients)0 || Ingre == (Ingredients)1 || Ingre == (Ingredients)2)
                {
                    listIngredient.Remove((Ingredients)0);
                    listIngredient.Remove((Ingredients)1);
                    listIngredient.Remove((Ingredients)2);
                    listIngredient.Add(Ingre);
                }
                else
                    listIngredient.Add(Ingre);
            }
        }
       public int modifQte(int valeur)
        {
            if (Quantité >= 0)
                Quantité += valeur;
            return Quantité;
        }

        public override string ToString()
        {
            string Afficher = "";
            Afficher += $"{Nom} {Description} {Image} ";
            foreach (Ingredients element in ListIngredient)
            {
                Afficher += $"{element} ";
            }
            Afficher += $"{Prix} {Quantité} ";
            return Afficher;
        }

        public bool Equals(Pizza other)
        {
            return Nom == other.Nom;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return false;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Pizza);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
