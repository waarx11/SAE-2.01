using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Modele
{
    public partial class Manager
    {
        public ReadOnlyCollection<Pizza> Pizzas { get; private set; }
        private List<Pizza> pizzas = new List<Pizza>();

        public Pizza SelectedPizza { get; set; }

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

        public Pizza GetPizza(Pizza pizza)
        {
            return pizzas.SingleOrDefault(p => p.Equals(pizza));
        }

        public Pizza GetPizza(string nom, List<Ingredients> list, string description, string image, int prix)
        {
            return GetPizza(new Pizza(nom, description, image, list, prix));
        }

        public Pizza ModifiePizza(Pizza pizzOld, Pizza pizzNew)
        {
            return null;
        }


    }
}
