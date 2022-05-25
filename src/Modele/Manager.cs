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
            C1.CatalogueVegetarien.Add(new Pizza("Reine", "Bonne", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)2, (Ingredients)20 }, 15));
            /*C1.CatalogueVegetarien.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
                new Pizza("tkt", "non", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 }, 102),
                new Pizza("Saucisse", "gourmande", "../img/pizzas/epicees/chicken_barbecue.jpeg", new List<Ingredients> { (Ingredients)2, (Ingredients)20, (Ingredients)35 }),
            });*/

            C1.CataloguePizzeta.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
                new Pizza("tkt", "non", "oui", new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 }, 102),
                new Pizza("Saucisse", "gourmande", "non", new List<Ingredients> { (Ingredients)2, (Ingredients)20, (Ingredients)35 }),
            });

            C1.CatalogueCarnivore.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
                new Pizza("tkt", "non", "oui", new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 }, 102),
                new Pizza("Saucisse", "gourmande", "non", new List<Ingredients> { (Ingredients)2, (Ingredients)20, (Ingredients)35 }),
            });

            C1.CatalogueEpice.AddRange(new Pizza[]
            {
                new Pizza("Reine", "Bonne", "oui", new List<Ingredients> { (Ingredients)2, (Ingredients)20 } , 15),
                new Pizza("tkt", "non", "oui", new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 }, 102),
                new Pizza("Saucisse", "gourmande", "non", new List<Ingredients> { (Ingredients)2, (Ingredients)20, (Ingredients)35 }),
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
