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
        public string Nom { get; private set; }

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public int Quantité { get; private set; } = 1;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string Image { get; private set; }

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public int Prix { get; private set; }

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
            string nom = string.IsNullOrWhiteSpace(Nom) ? "" : $"\"{Nom}\"";
            string description = string.IsNullOrWhiteSpace(Description) ? "" : $"\"{Description}\"";
            string image = string.IsNullOrWhiteSpace(Image) ? "" : $"\"{Image}\"";
            string prix = string.IsNullOrWhiteSpace(Prix.ToString()) ? "" : $"\"{Prix}\"";
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
