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
    /// Ceci est une partie du manager et il correspond a la partie Commande
    /// </summary>
    public partial class Manager
    {
        /// <summary>
        /// Crée une commande et une variable readonly qui sera égale a cette commande
        /// </summary>
        public ReadOnlyCollection<Commande> Commandes { get; private set; }
        private List<Commande> commandes = new List<Commande>();

        /// <summary>
        /// Ajouter une commande
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>true si ca a fonctionnné false sinon</returns>
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

        /// <summary>
        /// Supprime une commande
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>true si ca a fonctionnné false sinon</returns>
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

        /// <summary>
        /// Récupérer une commande
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>La commande voulue</returns>
        public Commande GetCommande(Commande cmd)
        {
            return commandes.SingleOrDefault(c => c.Equals(cmd));
        }

        /// <summary>
        /// Récupérer une commande
        /// </summary>
        /// <param name="clientActu"></param>
        /// <param name="listPizz"></param>
        /// <returns>La commande voulue</returns>
        public Commande GetCommande(Client clientActu, ObservableCollection<Pizza> listPizz)
        {
            return GetCommande(new Commande(clientActu, listPizz));
        }

        /// <summary>
        /// Modifie une commande
        /// </summary>
        /// <param name="cmdOld"></param>
        /// <param name="cmdNew"></param>
        /// <returns>null</returns>
        public Commande ModifieCommande(Commande cmdOld, Pizza cmdNew)
        {
            return null;
        }


    }
}
