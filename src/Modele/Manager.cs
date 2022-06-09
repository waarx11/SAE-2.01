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
    /// Ceci est une partie du manager mais il globalise tout
    /// </summary>
    public partial class Manager : INotifyPropertyChanged
    {
        public IPersistanceManager Persistance { get; /*private*/ set; }
        public Manager(IPersistanceManager p)
        {
            Persistance = p;
            Administrateurs = new ReadOnlyCollection<Administrateur>(administrateurs);
            Clients = new ReadOnlyCollection<Client>(clients);
            Pizzas = new ReadOnlyCollection<Pizza>(pizzas);
            Catalogues = C1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        /// <summary>
        /// Cette fonction permet de charger les donnée de l'application
        /// </summary>
        public void ChargeDonnées() // <=== dépendance
        {
            var donnee = Persistance.ChargeDonnées();
            foreach (var us in donnee.client)
            {
                clients.Add(us);
            }
            foreach (var adm in donnee.admin)
            {
                administrateurs.Add(adm);
            }
            var cat = donnee.catalogue;
            foreach (var catV in cat.CatalogueVegetarien)
            {
                C1.CatalogueVegetarien.Add(catV);
            }
                
            foreach (var catV in cat.CatalogueEpice)
            {
                C1.CatalogueEpice.Add(catV);
            }
            foreach (var catV in cat.CatalogueCarnivore)
            {
                C1.CatalogueCarnivore.Add(catV);
            }
            foreach (var catV in cat.CataloguePizzeta)
            {
                C1.CataloguePizzeta.Add(catV);
            }
        }

        /// <summary>
        /// Cette fonction permet de sauvegardé les données de l'application
        /// </summary>
        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(Clients, Administrateurs, Catalogues); // <=== dépendance
        }

        /// <summary>
        /// Cette fonction permet de gérée la connection d'un client et d'un administrateur
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pass"></param>
        /// <returns>1 si l'administrateur peut ce connecter, 2 si l'administrateur n'a pas saisie le bon mot de passe, 3 si le client peut ce connecter, 4 si le client n'a pas saisie le bon mot de passe</returns>
        public int connecterUtilisateur(string log,string pass)
        {
            foreach(Administrateur u1 in Administrateurs)
            {
                if(u1.Email== log || u1.NomPizzeria==log)
                {
                    if (u1.Mdp == pass)
                    {
                        UtilisateurActuel = u1;
                        return 1;
                    }
                        
                    return 2;
                }

            }
            foreach (Client c1 in Clients)
            {
                if (c1.Email == log || c1.Pseudo == log)
                {
                    if (c1.Mdp == pass)
                    {
                        UtilisateurActuel = c1;
                        return 3;
                    }
                    return 4;
                }
            }
            return -1;
        }

        public int selectionnerPizza(string nom)
        {
            foreach (Pizza p in C1.CataloguePizzeta)
            {
                if (p.Nom == nom)
                {
                    PizzaActuelle = p;
                    return 1;
                }
            }
            foreach (Pizza p in C1.CatalogueCarnivore)
            {
                if (p.Nom == nom)
                {
                    PizzaActuelle = p;
                    return 1;
                }
            }
            foreach (Pizza p in C1.CatalogueVegetarien)
            {
                if (p.Nom == nom)
                {
                    PizzaActuelle = p;
                    return 1;
                }
            }
            foreach (Pizza p in C1.CatalogueEpice)
            {
                if (p.Nom == nom)
                {
                    PizzaActuelle = p;
                    return 1;
                }
            }
            return -1;
        }

        public int creationUtilisateur(string id, string email, string mdp)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mdp))
                return 0;//Tout les information doivent etre rentre
            foreach (Client c1 in Clients)
            {
                if (c1.Pseudo == id)
                {
                    if (c1.Email == email)
                    {
                        return -1;//Pseudo et email deja existant
                    }
                    return -2;//Pseudo deja existant 
                }

                if (c1.Email == email || !email.Contains("@"))
                    return -3;//Email déja existant
            }
            clients.Add(new Client(email, id, mdp));
            return 1;
        }
    }
}
