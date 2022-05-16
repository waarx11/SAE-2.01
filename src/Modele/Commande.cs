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

    }
}
