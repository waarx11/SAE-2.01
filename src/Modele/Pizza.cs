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
        public string Quantité { get => quantité; set => quantité = value; }
        private string quantité;

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
        private List<Ingredients> ListIngredient = new List<Ingredients> {(Ingredients)53, (Ingredients)0};
        public List<Ingredients> listIngredient { get => ListIngredient; set => ListIngredient = value; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de cette pizza</param>
        /// <param name="description">Description de cette pizza</param>
        /// <param name="image">Image de cette pizza</param>
        /// <param name="prix">Prix de cette pizza</param>

        public Pizza(string nom, string description, string image, int prix=12)
        {
            if(string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(image))
            {
                throw new ArgumentException("Une pizza doit avoir au moins un nom, une description et une image");
            }
            Nom =nom;
            Description = description;
            Image = image;
            Prix = prix;
        }
       /* public int modifQte(int valeur)
        {
            if (Quantité > 0)
                Quantité += valeur;
        }*/

        public override string ToString()
        {
            string nom = string.IsNullOrWhiteSpace(Nom) ? "" : $"{Nom}";
            string description = string.IsNullOrWhiteSpace(Description) ? "" : $"{Description}";
            string image = string.IsNullOrWhiteSpace(Image) ? "" : $"{Image}";
            string prix = string.IsNullOrWhiteSpace(Prix.ToString()) ? "" : $"{Prix}";
            return $"{nom} \"{description}\" {image} {prix} {Quantité}";
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
