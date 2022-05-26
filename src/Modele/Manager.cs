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
    public partial class Manager /*: INotifyPropertyChanged*/
    {

        public Manager(/*IPersistanceManager p*/)
        {
            //Persist = p;
            Administrateurs = new ReadOnlyCollection<Administrateur>(administrateurs);
            Clients = new ReadOnlyCollection<Client>(clients);
            Catalogues = C1;
        }

        /// <summary>
        /// Cette fonction permet de charger les donnée de l'application
        /// </summary>
        public void ChargeDonne()
        {
            administrateurs.Add(new Administrateur("Peroni", "Luigi", "Luigi.PERONI@NewPizza.com", "09.25.25.80.18", "4 Avenue BlaiseMcool", "Clermont-Ferrand", "63000", "0000", "NewPizza()"));
            ChargeClient();
            ChargeCatalogue();
        }

        /// <summary>
        /// Cette fonction crée les donnée des clients
        /// </summary>
        public void ChargeClient()
        {
            clients.AddRange(new Client[]
            {
                new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "0", "0", "non"),
                new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "oui", "tobiii", "non"),
                new Client("Verdier", "Nathan", "Nathan@oui.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand",  "63000", "non", "Waarx"),
                new Client("Bonneau", "Baptiste", "Baptiste@oui.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand", "63000", "tkt", "nojji", "img"),
        });
        }

        /// <summary>
        /// Cette fonction crée les données des catalogues
        /// </summary>
        public void ChargeCatalogue()
        {
            C1.CatalogueVegetarien.Add(new Pizza("Chèvre Miel Végé", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, Base crème, mozzarella, fromage de chèvre, miel", "../img/pizzas/vegetariennes/chevre_miel_vege.jpg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Miel }, 14));
            C1.CatalogueVegetarien.Add(new Pizza("Reine", "Bonne", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)2, (Ingredients)20 }, 15));
            C1.CatalogueVegetarien.Add(new Pizza("tkt", "non", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 }, 102));
            C1.CatalogueVegetarien.Add(new Pizza("Saucisse", "gourmande", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)2, (Ingredients)20, (Ingredients)35 }));

            C1.CataloguePizzeta.Add(new Pizza("5 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, gorgonzola, taleggio de Lombardie, fromage de chèvre, scamorza fumée", "../img/pizzas/pizzeta/pizzeta_5_fromaggi.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Taleggio, Ingredients.FromageDeChevre, Ingredients.Scamorza }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Carbonara", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, pancetta, oeuf", "../img/pizzas/pizzeta/pizzeta_carbonara.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Pancetta, Ingredients.Oeuf }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Chèvre Miel", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, speck, roquette, miel", "../img/pizzas/pizzeta/pizzeta_chevre_miel.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Speck, Ingredients.Salade, Ingredients.Miel }, 10));

            C1.CatalogueCarnivore.Add(new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 }, 15));

            C1.CatalogueEpice.Add(new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 }, 15));
        }

        /// <summary>
        /// Cette fonction permet de gérée la connection d'un client et d'un administrateur
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pass"></param>
        /// <returns>1 si l'administrateur peut ce connecter, 2 si l'administrateur n'a pas saisie le bon mot de passe, 3 si le client peut ce connecter, 4 si le client n'a pas saisie le bon mot de passe</returns>
        public int connecterUtilisateur(string log,string pass)
        {
            int codeRetour=-1;
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
            return codeRetour;
        }
    }
}
