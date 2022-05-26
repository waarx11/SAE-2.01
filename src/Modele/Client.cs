using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette class permet de crée un client et elle hérite de la class utilisateur
    /// </summary>
    public class Client : Utilisateur
    {
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        public string Pseudo { get => pseudo; private set => pseudo = value; }
        private string pseudo;
        /// <summary>
        /// Photo de l'utilisateur
        /// </summary>
        private string photo;
        public string Photo { get => photo; private set => photo = value; }


        /// <summary>
        /// Liste des commandes du client
        /// </summary>
        private List<Commande> listCommandeClient = new List<Commande> { };
        public List<Commande> ListCommandeClient { get => listCommandeClient; set => listCommandeClient = value; }

        /// <summary>
        /// Constructeur d'un Client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="pseudo"></param>
        /// <param name="photo"></param>
        public Client(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string pseudo, string photo=null)
            :base(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp)
        {

            if (string.IsNullOrWhiteSpace(pseudo))
            {
                throw new ArgumentException("Pseudo invalide");
            }
            else
            {
                Pseudo = pseudo;
            }

            if (string.IsNullOrWhiteSpace(photo))
            {
                Photo = "default\noPP.jpg";
            }
            else
            {
                Photo = photo;
            }
        }

        /// <summary>
        /// Permet de mettre a jour les informations d'un client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="pseudo"></param>
        /// <param name="photo"></param>
        public void EnregistrerModif(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo)
        {
            EnregistrerModif(nom, prénom, email, téléphone, adresse, ville, codePostal);
            Pseudo = pseudo;
            Photo = photo;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Pseudo} {Photo}";
        }

        public void envoyerListeCommande(Administrateur admin)
        {
            KeyValuePair<Client, List<Commande>> paire = new KeyValuePair<Client, List<Commande>>(this, listCommandeClient) { };
            admin.ListCommandeAdmin.Add(paire);
            ListCommandeClient.Clear();
           
        }

        public void ajouterCommandeAuPanier(Commande c)
        {
            foreach(Pizza p in c.ListPizza)
            {
                if(p.Quantité <= 0)
                {
                    c.ListPizza.Remove(p);
                }
            }
            ListCommandeClient.Add(c);
        }

    }
}
