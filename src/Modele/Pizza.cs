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
        /// <param name="quantité">Quantité de cette pizza a commander</param>
        public Pizza(string nom, string description, string image, int prix)
        {
            Nom=nom;
            Description = description;
            Image = image;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"{Nom}\"{Description}\"{Image}\"{Prix}\"{Quantité}\"";
        }

    }
}
