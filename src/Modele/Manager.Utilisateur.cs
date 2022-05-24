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
        public ReadOnlyCollection<Client> Clients { get; private set; }
        List<Client> clients = new List<Client>();
        public ReadOnlyCollection<Administrateur> Administrateurs { get; private set; }
        List<Administrateur> administrateurs = new List<Administrateur>();

        // public Catalogue Catalogue { get; private set; }
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

        public Administrateur GetAdministrateur(Administrateur administrateur)
        {
            return administrateurs.SingleOrDefault(a => a.Equals(administrateur));
        }

        public Client GetClient(Client client)
        {
            return clients.SingleOrDefault(a => a.Equals(client));
        }

        public Administrateur GetAdministrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string nomPizzeria)
        {
            return GetAdministrateur(new Administrateur(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, nomPizzeria));
        }

        public Client GetClient(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string pseudo, string photo = null)
        {
            return GetClient(new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, pseudo, photo));
        }

        public Administrateur ModifieAdmin(Administrateur adOld, Administrateur adNew)
        {
            return null;
        }
    }
}
