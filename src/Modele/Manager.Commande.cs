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
        public ReadOnlyCollection<Commande> Commandes { get; private set; }
        private List<Commande> commandes = new List<Commande>();

        public bool AjouteCommande(Commande cmd)
        {
            if (cmd == null)
            {
                return false;
            }

            if (commandes.Contains(cmd))
            {
                return false;
            }
            commandes.Add(cmd);
            return true;
        }

        public bool SupCommande(Commande cmd)
        {
            if (cmd == null)
            {
                return false;
            }

            if (commandes.Contains(cmd))
            {
                return false;
            }
            commandes.Remove(cmd);
            return true;
        }

        public Commande GetCommande(Commande cmd)
        {
            return commandes.SingleOrDefault(c => c.Equals(cmd));
        }

        public Commande GetCommande(Client clientActu, List<Pizza> listPizz)
        {
            return GetCommande(new Commande(clientActu, listPizz));
        }

        public Commande ModifieCommande(Commande cmdOld, Pizza cmdNew)
        {
            return null;
        }


    }
}
