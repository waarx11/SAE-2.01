using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Ceci est une partie du manager et il correspond a la partie Pizza
    /// </summary>
    public partial class Manager
    {
        /// <summary>
        /// Crée une commande et une variable readonly qui sera égale a cette pizza
        /// </summary>
        public ReadOnlyCollection<Pizza> Pizzas { get; private set; }
        private List<Pizza> pizzas = new List<Pizza>();

        /// <summary>
        /// Ajouter une pizza
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns>true si ca a fonctionnné false sinon</returns>
        public bool AjoutePizza(Pizza pizza)
        {
            if (pizza == null)
            {
                return false;
            }

            if (pizzas.Contains(pizza))
            {
                return false;
            }
            pizzas.Add(pizza);
            return true;
        }

        /// <summary>
        /// Supprimer une pizza
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns>true si ca a fonctionnné false sinon</returns>
        public bool SupPizza(Pizza pizza)
        {
            if (pizza == null)
            {
                return false;
            }

            if (pizzas.Contains(pizza))
            {
                return false;
            }
            pizzas.Remove(pizza);
            return true;
        }

        /// <summary>
        /// Récupérer une pizza
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns>La pizza voulue</returns>
        public Pizza GetPizza(Pizza pizza)
        {
            return pizzas.SingleOrDefault(p => p.Equals(pizza));
        }

        /// <summary>
        /// Récupérer une pizza
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="list"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        /// <param name="prix"></param>
        /// <returns>La pizza voulue</returns>
        public Pizza GetPizza(string nom, List<Ingredients> list, string description, string image, int prix)
        {
            return GetPizza(new Pizza(nom, description, image, list, prix));
        }
        /// <summary>
        /// Modifie une pizza
        /// </summary>
        /// <param name="pizzOld"></param>
        /// <param name="pizzNew"></param>
        /// <returns>null</returns>
        public Pizza ModifiePizza(Pizza pizzOld, Pizza pizzNew)
        {
            return null;
        }


    }
}
