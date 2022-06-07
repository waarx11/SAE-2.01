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
        public string Nom { get => nom; private set => nom = value; }
        private string nom;

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public int Quantité { get => quantité; private set => quantité = value; }
        private int quantité = 1;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Description { get => description; private set => description = value; }
        private string description;

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string ImageName { get => image; private set => image = value; }
        private string image;

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public int Prix { get => prix; private set => prix = value; }
        private int prix;

        /// <summary>
        /// Liste des ingredient qui constitue la pizza
        /// </summary>
        private List<Ingredients> ListIngredient = new List<Ingredients> {(Ingredients)53, (Ingredients)0 };
        public List<Ingredients> listIngredient { get => ListIngredient; set => ListIngredient = value; }

        /// <summary>
        /// Constructeur de la classe pizza
        /// </summary>
        /// <param name="nom">Nom de cette pizza</param>
        /// <param name="description">Description de cette pizza</param>
        /// <param name="image">Image de cette pizza</param>
        /// <param name="prix">Prix de cette pizza</param>

        public Pizza(string nom, string description, string image, List<Ingredients> lIng, int prix=12)
        {

            if (string.IsNullOrWhiteSpace(nom))
            {
                Nom = "Aucun Nom";
            }
            else
            {
                Nom = nom;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                Description = "Aucune Description";
            }
            else
            {
                Description = description;
            }

            if (string.IsNullOrWhiteSpace(image))
            {
                ImageName = "default\noImg.png";
            }
            else
            {
                ImageName = image;
            }

            if(prix <= 5)
            {
                Prix = 12;
            }
            else
            {
                Prix = prix;
            }

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
        /// <summary>
        /// Cette fonction permet de modifier la quantiter de pizza voulue 
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns>La quantité souhaiter de cette pizza</returns>
       public int modifQte(int valeur)
       {
            int qteTmp = Quantité;

            qteTmp += valeur;

            if (qteTmp >= 0)
                Quantité = qteTmp;

            return Quantité;
        }

        public override string ToString()
        {
            string Afficher = "";
            Afficher += $"{Nom} {Description} {ImageName} ";
            foreach (Ingredients element in ListIngredient)
            {
                Afficher += $"{element} ";
            }
            Afficher += $"{Prix} {Quantité} ";
            return Afficher;
        }
        /// <summary>
        /// Return true si deux pizza on le même nom
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Pizza other)
        {
            return Nom == other.Nom;
        }
        /// <summary>
        /// Cette fonction return true si obj existe dans pizza
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        public override bool Equals(object obj)
        {
            /*if (obj == null) return false;
            if (obj == this) return false;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Pizza);*/
            if (object.ReferenceEquals(obj, null)) return false;
            if (object.ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;
            return this.Equals(obj as Pizza);
        }
        /// <summary>
        /// Fonction de hashage
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
