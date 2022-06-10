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
    /// Ceci est une partie du manager et il correspond a la partie utilisateur
    /// </summary>
    public partial class Manager
    {
        /// <summary>
        /// Crée une liste clients et une ReadOnlyCollection Clients qui sera égale à clients
        /// </summary>
        public ReadOnlyCollection<Client> Clients { get; private set; }
        private List<Client> clients = new List<Client>();

        /// <summary>
        /// Crée une liste administrateurs et une ReadOnlyCollection Administrateurs qui sera égale à administrateurs
        /// </summary>
        public ReadOnlyCollection<Administrateur> Administrateurs { get; private set; }
        private List<Administrateur> administrateurs = new List<Administrateur>();


        /// <summary>
        /// Ajout un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteClient(Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (clients.Contains(client))
            {
                return false;
            }
            clients.Add(client);
            return true;
        }

        /// <summary>
        /// Ajout un administrateur
        /// </summary>
        /// <param name="administrateur"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteAdministrateur(Administrateur administrateur)
        {
            if (administrateur == null)
            {
                return false;
            }

            if (administrateurs.Contains(administrateur))
            {
                return false;
            }
            administrateurs.Add(administrateur);
            return true;
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppClient(Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (clients.Contains(client))
            {
                return false;
            }
            clients.Remove(client);
            return true;
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="administrateur"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppAdministrateur(Administrateur administrateur)
        {
            if (administrateur == null)
            {
                return false;
            }

            if (administrateurs.Contains(administrateur))
            {
                return false;
            }
            administrateurs.Remove(administrateur);
            return true;
        }

        /// <summary>
        /// Permet l'affichage d'un administrateur
        /// </summary>
        /// <param name="administrateur"></param>
        /// <returns>L'administrateur voulue</returns>
        public Administrateur GetAdministrateur(Administrateur administrateur)
        {
            return administrateurs.SingleOrDefault(a => a.Equals(administrateur));
        }

        /// <summary>
        /// Permet l'affichage d'un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Le client voulue</returns>
        public Client GetClient(Client client)
        {
            return clients.SingleOrDefault(a => a.Equals(client));
        }

        /// <summary>
        /// Permet l'affichage d'un administrateur via toute ces information personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="mdp"></param>
        /// <param name="nomPizzeria"></param>
        /// <returns>L'administrateur voulue</returns>
        public Administrateur GetAdministrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string nomPizzeria)
        {
            return GetAdministrateur(new Administrateur(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, nomPizzeria));
        }

        /// <summary>
        /// Permet l'affichage d'un client via toute ces information personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="mdp"></param>
        /// <param name="pseudo"></param>
        /// <param name="photo"></param>
        /// <returns>Le client voulue</returns>
        public Client GetClient(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string pseudo, string photo = null)
        {
            return GetClient(new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, pseudo, photo));
        }

        /// <summary>
        /// Modifier un administrateur
        /// </summary>
        /// <param name="adOld"></param>
        /// <param name="adNew"></param>
        /// <returns>return un administrateur modifier</returns>
        public Administrateur ModifieAdmin(Administrateur adOld, Administrateur adNew)
        {
            return null;
        }

        /// <summary>
        /// Modifier un client
        /// </summary>
        /// <param name="clOld"></param>
        /// <param name="clNew"></param>
        /// <returns>return un client modifier</returns>
        public Client ModifieClient(Client clOld, Client clNew)
        {
            return null;
        }
    }
}
