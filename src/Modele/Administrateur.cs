using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette class permet de crée un administrateur et elle hérite de la class utilisateur
    /// </summary>
    public class Administrateur : Utilisateur

    {
        /// <summary>
        /// nom de la pizzeria 
        /// </summary>
        private string nomPizzeria;
        public string NomPizzeria { get => nomPizzeria; private set => nomPizzeria = value; }


        /// <summary>
        /// Liste de toutes les commandes
        /// </summary>
        private List<Commande> listCommandeAdmin;
        public List<Commande> ListCommandeAdmin { get => listCommandeAdmin; private set => listCommandeAdmin = value; }

        /// <summary>
        /// Construteur de la classe Administrateur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="nomPizzeria"></param>
        public Administrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp,  string nomPizzeria)
            :base(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp)
        {
            NomPizzeria = nomPizzeria;
            listCommandeAdmin = new List<Commande>();
        }

        public void ChangerStatusCommande(Commande C1)
        {
            if (C1 == null)
                return;
            if (ListCommandeAdmin.Contains(C1))
            {
                ListCommandeAdmin.Remove(C1);
                C1.changerStatus();
                if (C1.Statut != Status.Finir)
                    ListCommandeAdmin.Add(C1);
            }
        }

        public void SuppCommande(Commande C1)
        {
            ListCommandeAdmin.Remove(C1);
        }

        public override string ToString()
        {
            return $"{base.ToString()} {nomPizzeria}";
        }
    }
}
