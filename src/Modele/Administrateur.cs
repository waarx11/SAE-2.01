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
        private HashSet<KeyValuePair<Client, List<Commande>>> listCommandeAdmin = new HashSet<KeyValuePair<Client, List<Commande>>> { };
        public HashSet<KeyValuePair<Client, List<Commande>>> ListCommandeAdmin { get => listCommandeAdmin; set => listCommandeAdmin = value; }

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
        }

        /// <summary>
        /// Permet de modifier les informations d'un administrateur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="nomPizzeria"></param>
        public void EnregistrerModif(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string nomPizzeria)
        {
            EnregistrerModif(nom, prénom, email, téléphone, adresse, ville, codePostal);
            NomPizzeria = nomPizzeria;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {nomPizzeria}";
        }
    }
}
