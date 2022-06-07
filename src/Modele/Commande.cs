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

        private Status statut;
        public Status Statut { get => statut; private set => statut = value; }

        /// <summary>
        /// Le constructeur reçois un client actuelle et une liste de pizza
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="listPzz"></param>
        public Commande(Client c1, List<Pizza> listPzz)
        {
            ListPizza = new List<Pizza>();
            ClientActu = c1;
            Statut = Status.Commencer;
        }

        public void changerStatus()
        {
            if (statut == Status.Commencer)
            {
                statut = Status.EnCours;
                return;
            }

            if (statut == Status.EnCours)
            {
                statut = Status.Finir;
                return;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return false;
            if (obj.GetType() != this.GetType()) return false;
            Commande cmd = (Commande)obj;
            if (cmd == null) return false;
            return cmd.ListPizza == ListPizza && cmd.Statut == Statut;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string txt = $"{clientActu.Pseudo}, ";
            foreach (Pizza p in ListPizza)
            {
                txt += $"{p}, ";
            }
            txt += $"{statut}";

            return txt;
        }

    }
}
