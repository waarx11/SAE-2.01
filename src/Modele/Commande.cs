using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette fonction permet a un client de passer une commande
    /// </summary>
    public class Commande
    {
        /// <summary>
        /// La liste des pizza présent dans la commande
        /// </summary>
        private List<Pizza> listPizza;
        public List<Pizza> ListPizza { get => listPizza; private set => listPizza = value; }

        /// <summary>
        /// Le client actuel qui passe commande
        /// </summary>
        private Client clientActu;
        public Client ClientActu { get => clientActu; private set => clientActu = value; }

        /// <summary>
        /// Le constructeur reçois un client actuelle et une liste de pizza
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="listPzz"></param>
        public Commande(Client c1, List<Pizza> listPzz)
        {
            ListPizza = new List<Pizza>();
            ClientActu = c1;
        }

    }
}
