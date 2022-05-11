using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Commande
    {
        private List<Pizza> listCommande;
        public List<Pizza> ListCommande { get => listCommande; set => listCommande = value; }

        public Commande(Client c1, List<Pizza> listPizza)
        {
            listCommande = new List<Pizza>();
        }
        public void ajoutePizzaCommande(Pizza pizza)
        {
            listCommande.Add(pizza);
        }
        public void suppPizzaCommande(Pizza pizza)
        {
            listCommande.Remove(pizza);
        }

    }
}
