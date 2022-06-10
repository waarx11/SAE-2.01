using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        /*[DataMember(EmitDefaultValue = false, Order = 8)]*/
        public string NomPizzeria { get => nomPizzeria; private set => nomPizzeria = value; }


        /// <summary>
        /// Liste de toutes les commandes
        /// </summary>
        private List<Commande> listCommandeAdmin;
        /*[DataMember(EmitDefaultValue = false, Order = 9)]*/
        public List<Commande> ListCommandeAdmin
        {
            get => listCommandeAdmin;
            set
            {
                if (ListCommandeAdmin != value)
                {
                    listCommandeAdmin = value;
                    OnPropertyChanged(nameof(ListCommandeAdmin));
                }
            }
        }

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
        public Administrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string nomPizzeria)
            : base(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp)
        {
            NomPizzeria = nomPizzeria;
            ListCommandeAdmin = new List<Commande>();
        }


        /// <summary>
        /// Permet de modifier le status d'une commande
        /// </summary>
        /// <param name="C1"></param>
        public void ChangerStatusCommande(Commande C1)
        {
            if (C1 == null)
                return;

            if (ListCommandeAdmin.Contains(C1))
            {
                C1.changerStatus();
                if (C1.Statut == Status.Finir)
                {
                    ListCommandeAdmin.Remove(C1);
                }
            }
        }

        /// <summary>
        /// Permet de supprimer une commande
        /// </summary>
        /// <param name="C1"></param>
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
