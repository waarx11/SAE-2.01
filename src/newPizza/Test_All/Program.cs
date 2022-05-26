using System;
using System.Collections.Generic;
using Modele;

namespace Test_All
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Pizzza et des User");
            List<Ingredients> lIngre1 = new List<Ingredients> { (Ingredients)2, (Ingredients)20 };
            List<Ingredients> lIngre2 = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza P1 = new Pizza("Reine", "Bonne", "oui", lIngre1, 15);
            Pizza P2 = new Pizza("tkt", "non", "oui", lIngre1, 102);
            Pizza P3 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Pizza P4 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Pizza P5 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Client C1 = new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "Mdp", "tobiii", "non");
            Catalogue Cat1 = new Catalogue();

            Cat1.CatalogueVegetarien.Add(P1);
            Cat1.CataloguePizzeta.Add(P2);
            Cat1.CatalogueCarnivore.Add(P3);
            Cat1.CatalogueEpice.Add(P4);

            Console.WriteLine("Pizzeria");
            Administrateur A1 = new Administrateur("Bonneau", "Baptiste", "Baptiste@oui.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand", "63000", "Jesuisunmdp", "nojii");
         
            Console.WriteLine(C1);
            C1.EnregistrerModif("aze", "ertre", "emre@non.com", "06.12.85.95.15", "42 rue oui", "Ferrand", "63100", "dddddd", "je sais pas");
            Console.WriteLine(C1);

            Console.WriteLine(A1);
            A1.EnregistrerModif("Bonneau", "Baptiste", "Baptiste@non.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand", "63000", "newPizza1()");
            Console.WriteLine(A1);

            Console.WriteLine(P2.Equals(P3));
            Console.WriteLine(P4.Equals(P3));

            P1.modifQte(2);
            P2.modifQte(-2);
            P3.modifQte(100);
            P3.modifQte(-80);
            P4.modifQte(0);

            Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3);
            Console.WriteLine(Cat1);
        }
    }
}
