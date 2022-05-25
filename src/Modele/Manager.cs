using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;



namespace Modele
{
    public partial class Manager /*: INotifyPropertyChanged*/
    {

        public Manager(/*IPersistanceManager p*/)
        {
            //Persist = p;
            Administrateurs = new ReadOnlyCollection<Administrateur>(administrateurs);
            Clients = new ReadOnlyCollection<Client>(clients);
            Catalogues = C1;
        }

        public void ChargeDonne()
        {
            administrateurs.Add(new Administrateur("Peroni", "Luigi", "Luigi.PERONI@NewPizza.com", "09.25.25.80.18", "4 Avenue BlaiseMcool", "Clermont-Ferrand", "63000", "0000", "NewPizza"));
            ChargeClient();
            ChargeCatalogue();
        }

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

        public void ChargeCatalogue()
        {
            C1.CatalogueVegetarien.AddRange(new Pizza[]
            {
                new Pizza("3 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, gorgonzola", "../img/pizzas/vegetariennes/3_fromages.jpg", new List<Ingredients> {Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Gorgonzola} , 12),
                new Pizza("5 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, gorgonzola, taleggio de Lombardie, fromage de chèvre, scamorza fumée", "../img/pizzas/vegetariennes/5_formaggi.png", new List<Ingredients> {Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Taleggio, Ingredients.FromageDeChevre, Ingredients.Scamorza}, 15),
                new Pizza("Bianca", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base crème, mozzarella", "../img/pizzas/vegetariennes/bianca.png", new List<Ingredients> {Ingredients.PateFine, Ingredients.BaseCreme, Ingredients.Mozzarella}, 10),
                new Pizza("Carbonara", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base crème, mozzarella, pancetta, oeuf", "../img/pizzas/vegetariennes/carbonara.png", new List<Ingredients> {Ingredients.PateFine, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Pancetta, Ingredients.Oeuf}, 13),
                new Pizza("Carciofi", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base pesto de roquette, mozzarella, artichauts à la romaine, roquette, ricotta", "../img/pizzas/vegetariennes/carciofi.png", new List<Ingredients> {Ingredients.PateFine, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Artichaut, Ingredients.Salade, Ingredients.Ricotta}, 16),
                new Pizza("Chèvre Miel Végé", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, Base crème, mozzarella, fromage de chèvre, miel", "../img/pizzas/vegetariennes/chevre_miel_vege.jpg", new List<Ingredients> {Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Miel}, 14),
                new Pizza("Margarita", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base tomate, mozzarella", "../img/pizzas/vegetariennes/margarita.png", new List<Ingredients> {Ingredients.PateFine, Ingredients.BaseTomate, Ingredients.Mozzarella}, 10),
                new Pizza("Vegétarienne", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, champignons, oignons rouges, poivrons, tomates, olives", "../img/pizzas/vegetariennes/vegetarienne.jpeg", new List<Ingredients> {Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Champignons, Ingredients.OignonsRouges, Ingredients.Poivrons, Ingredients.Tomate, Ingredients.Olives}, 16)
            });

            C1.CataloguePizzeta.AddRange(new Pizza[]
            {
                new Pizza("5 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, gorgonzola, taleggio de Lombardie, fromage de chèvre, scamorza fumée", "../img/pizzas/pizzeta/pizzeta_5_fromaggi.png", new List<Ingredients> {Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Taleggio, Ingredients.FromageDeChevre, Ingredients.Scamorza}, 10),
                new Pizza("Carbonara", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, pancetta, oeuf", "../img/pizzas/pizzeta/pizzeta_carbonara.png", new List<Ingredients> {Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Pancetta, Ingredients.Oeuf}, 10),
                new Pizza("Chèvre Miel", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, speck, roquette, miel", "../img/pizzas/pizzeta/pizzeta_chevre_miel.png", new List<Ingredients> {Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Speck, Ingredients.Salade, Ingredients.Miel}, 10),

            });

            C1.CatalogueCarnivore.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
            });

            C1.CatalogueEpice.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
            });
        }

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
