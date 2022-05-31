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
                new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "0", "0"),
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
            C1.CatalogueVegetarien.Add(new Pizza("3 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, gorgonzola", "pizzas/vegetariennes/3_fromages.jpg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Gorgonzola }, 12));
            C1.CatalogueVegetarien.Add(new Pizza("5 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, gorgonzola, taleggio de Lombardie, fromage de chèvre, scamorza fumée", "pizzas/vegetariennes/5_formaggi.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Taleggio, Ingredients.FromageDeChevre, Ingredients.Scamorza }, 15));
            C1.CatalogueVegetarien.Add(new Pizza("Bianca", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base crème, mozzarella", "pizzas/vegetariennes/bianca.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.BaseCreme, Ingredients.Mozzarella }, 10));
            C1.CatalogueVegetarien.Add(new Pizza("Carbonara", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base crème, mozzarella, pancetta, oeuf", "pizzas/vegetariennes/carbonara.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Pancetta, Ingredients.Oeuf }, 13));
            C1.CatalogueVegetarien.Add(new Pizza("Carciofi", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base pesto de roquette, mozzarella, artichauts à la romaine, roquette, ricotta", "pizzas/vegetariennes/carciofi.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Artichaut, Ingredients.Salade, Ingredients.Ricotta }, 16));
            C1.CatalogueVegetarien.Add(new Pizza("Chèvre Miel Végé", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, Base crème, mozzarella, fromage de chèvre, miel", "pizzas/vegetariennes/chevre_miel_vege.jpg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Miel }, 14));
            C1.CatalogueVegetarien.Add(new Pizza("Margarita", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base tomate, mozzarella", "pizzas/vegetariennes/margarita.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.BaseTomate, Ingredients.Mozzarella }, 10));
            C1.CatalogueVegetarien.Add(new Pizza("Vegétarienne", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, champignons, oignons rouges, poivrons, tomates, olives", "pizzas/vegetariennes/vegetarienne.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Champignons, Ingredients.OignonsRouges, Ingredients.Poivrons, Ingredients.Tomate, Ingredients.Olives }, 16));
            
            
            C1.CataloguePizzeta.Add(new Pizza("5 Fromages", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, gorgonzola, taleggio de Lombardie, fromage de chèvre, scamorza fumée", "pizzas/pizzeta/pizzeta_5_fromaggi.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Taleggio, Ingredients.FromageDeChevre, Ingredients.Scamorza }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Carbonara", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, pancetta, oeuf", "pizzas/pizzeta/pizzeta_carbonara.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.Pancetta, Ingredients.Oeuf }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Chèvre Miel", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, speck, roquette, miel", "pizzas/pizzeta/pizzeta_chevre_miel.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Speck, Ingredients.Salade, Ingredients.Miel }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Chèvre Miel", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, fromage de chèvre, speck, roquette, miel", "pizzas/pizzeta/pizzeta_chevre_miel.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.Creme, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Speck, Ingredients.Salade, Ingredients.Miel }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Regina", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, jambon, champignons", "pizzas/pizzeta/pizzeta_regina.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate,Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Champignons }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Saumon", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, saumon fumé, pousses d’épinard, sauce balsamique blanc", "pizzas/pizzeta/pizzeta_salmone.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Saumon, Ingredients.Epinard, Ingredients.SauceBalsmamique }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Spécialité", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, jambon, oeuf, crème", "pizzas/pizzeta/pizzeta_speciale_pizzaiolo.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Oeuf, Ingredients.Creme }, 10));
            C1.CataloguePizzeta.Add(new Pizza("Vesuvio", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, merguez, spianata piccante, poivrons jaunes et rouges, oeuf plein air", "pizzas/pizzeta/pizzeta_vesuvio.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Merguez, Ingredients.SpianataPiccante, Ingredients.Poivrons, Ingredients.Oeuf }, 10));


            C1.CatalogueCarnivore.Add(new Pizza("3 Salumi", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base tomate, mozzarella, gorgonzola, coppa, speck, porchetta", "pizzas/carnivore/3_salumi.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Gorgonzola, Ingredients.Coppa, Ingredients.Speck, Ingredients.Porchetta }, 14));
            C1.CatalogueCarnivore.Add(new Pizza("Burrata e Mortadella", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, huile d’olive, parmigiano reggiano, mortadelle de Bologne, burrata des Pouilles, pistaches", "pizzas/carnivore/burrata_e_mortadella.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.HuileOlive, Ingredients.ParmigianoReggiano, Ingredients.Mortadelle, Ingredients.Burrata, Ingredients.Pistaches  }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Chevre Miel", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: pate normale, base crème, mozzarella, fromage de chèvre, speck, roquette, miel", "pizzas/carnivore/chevre_miel.png", new List<Ingredients> { Ingredients.PateFine, Ingredients.BaseCreme, Ingredients.FromageDeChevre, Ingredients.Speck, Ingredients.Salade, Ingredients.Miel }, 15));            
            C1.CatalogueCarnivore.Add(new Pizza("BPM", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, sauce barbecue, mozzarella, emietté au boeuf, filet de poulet rôti et merguez", "pizzas/carnivore/BPM.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.SauceBarbecue, Ingredients.Boeuf, Ingredients.Poulet, Ingredients.Merguez }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Campagnarde", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base crème, mozzarella, lardons, oignons rouges et champignons", "pizzas/carnivore/Campagnarde.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.Mozzarella, Ingredients.Lardons, Ingredients.OignonsRouges, Ingredients.Champignons }, 16));
            C1.CatalogueCarnivore.Add(new Pizza("Chicken Parmesan", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, filet de poulet rôti, tomates, parmigiano reggiano", "pizzas/carnivore/chicken_parmesan.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Poulet, Ingredients.Tomate, Ingredients.ParmigianoReggiano }, 13));           
            C1.CatalogueCarnivore.Add(new Pizza("Del mare", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, mélange de fruits de mer (moules, palourdes, crevettes) et sauce crustacés, pousses d’épinard", "pizzas/carnivore/del_mare.png", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.FruitsDeMer, Ingredients.SauceCrustacés, Ingredients.Epinard }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Diavola", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, parmigiano reggiano, poivrons, ‘nduja, oignons rouges, mozzarella di Bufala Campana", "pizzas/carnivore/diavola.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.ParmigianoReggiano, Ingredients.Poivrons, Ingredients.nduja, Ingredients.OignonsRouges, Ingredients.Mozzarella }, 12));
            C1.CatalogueCarnivore.Add(new Pizza("Saumon", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base crème, mozzarella, saumon fumé, pousses d’épinard, sauce balsamique blanc", "pizzas/carnivore/salmone.png", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseCreme, Ingredients.Saumon, Ingredients.Epinard, Ingredients.SauceBalsmamique }, 15));            
            C1.CatalogueCarnivore.Add(new Pizza("Kasbah", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, émincé de poulet kebab, tomates, oignons rouges et sauce blanche kebab", "pizzas/carnivore/kasbah.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Poulet, Ingredients.Tomate, Ingredients.OignonsRouges, Ingredients.SauceBlancheKebab }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Nordique", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella et saumon fumé de Norvège", "pizzas/carnivore/nordique.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Saumon }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Pepperoni lovers", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate fine, base tomate, mozzarella et saucisse pepperoni", "pizzas/carnivore/pepperoni_lovers.jpeg", new List<Ingredients> { Ingredients.PateFine, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Pepperoni }, 16));          
            C1.CatalogueCarnivore.Add(new Pizza("Pomodoro e burrata", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, tomates cerise, parmigiano reggiano, salade, burrata des Pouilles, porchetta", "pizzas/carnivore/pomodoro_e_burrata.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Tomate, Ingredients.ParmigianoReggiano, Ingredients.Salade, Ingredients.Burrata, Ingredients.Porchetta }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Speciale", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, jambon, oeuf, crème", "pizzas/carnivore/speciale_pizzaiolo.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Oeuf, Ingredients.Creme }, 14));
            C1.CatalogueCarnivore.Add(new Pizza("Regina", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, jambon, champignons", "pizzas/carnivore/regina.png", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Champignons }, 15));   
            C1.CatalogueCarnivore.Add(new Pizza("Texane barbecue", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, sauce barbecue, mozzarella, jambon, emietté au boeuf, lardons, champignons et oignons rouges.", "pizzas/carnivore/texane_barbecue.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.SauceBarbecue, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Boeuf, Ingredients.Lardons, Ingredients.Champignons, Ingredients.OignonsRouges }, 15));
            C1.CatalogueCarnivore.Add(new Pizza("Raclette", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, pommes de terre, lardons et fromage à raclette", "pizzas/carnivore/raclette.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.PommesDeTerre, Ingredients.Lardons, Ingredients.FromageARaclette }, 14));
            C1.CatalogueCarnivore.Add(new Pizza("Montagnarde", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base crème, mozzarella, jambon, fromage à raclette et champignons", "pizzas/carnivore/montagnarde.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseCreme, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.FromageARaclette, Ingredients.Champignons }, 14));
            C1.CatalogueCarnivore.Add(new Pizza("Vesuvio", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, merguez, spianata piccante, poivrons, oeuf", "pizzas/carnivore/vezuvio.png", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Merguez, Ingredients.SpianataPiccante, Ingredients.Poivrons, Ingredients.Oeuf }, 15));


            C1.CatalogueEpice.Add(new Pizza("Chicken Barbecue", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, sauce barbecue, mozzarella, filet de poulet rôti, oignons rouges, champignons et poivrons", "pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.SauceBarbecue, Ingredients.Mozzarella, Ingredients.Poulet, Ingredients.OignonsRouges, Ingredients.Champignons, Ingredients.Poivrons }, 15));
            C1.CatalogueEpice.Add(new Pizza("Orientale", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, merguez et champignons", "pizzas/epicees/orientale.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Merguez, Ingredients.Champignons }, 15));
            C1.CatalogueEpice.Add(new Pizza("Provencale", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate normale, base tomate, mozzarella, thon, tomates, oignons rouges et olives ", "pizzas/epicees/provencale.jpeg", new List<Ingredients> { Ingredients.PateNormale, Ingredients.BaseTomate, Ingredients.Thon, Ingredients.Tomate, Ingredients.OignonsRouges, Ingredients.Olives }, 15));
            C1.CatalogueEpice.Add(new Pizza("Samourai", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, merguez, filet de poulet rôti, oignons rouges, sauce samouraï ", "pizzas/epicees/samourai.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Merguez, Ingredients.Poulet, Ingredients.OignonsRouges, Ingredients.SauceSamourai }, 15));
            C1.CatalogueEpice.Add(new Pizza("Spicy hot one", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, emietté au boeuf, piments jalapeños, oignons rouges et tomates ", "pizzas/epicees/spicy_hot_one.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Boeuf, Ingredients.Piments, Ingredients.OignonsRouges, Ingredients.Tomate }, 15));
            C1.CatalogueEpice.Add(new Pizza("Supreme", "Tous les jours, la pâte à pizza newPizza est préparée et cuite à la commande dans nos restaurants par nos pizzaiolos. Voilà le secret de nos pizzas moelleuses et croustillantes.\n Ingrédients: Pate moyenne, base tomate, mozzarella, emietté au boeuf, saucisse pepperoni, champignons frais, oignons rouges et poivrons", "pizzas/epicees/supreme.jpeg", new List<Ingredients> { Ingredients.PateMoyenne, Ingredients.BaseTomate, Ingredients.Mozzarella, Ingredients.Pepperoni, Ingredients.Champignons, Ingredients.OignonsRouges, Ingredients.Poivrons }, 15));
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
