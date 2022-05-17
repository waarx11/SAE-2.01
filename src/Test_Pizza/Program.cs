using System;
using System.Collections.Generic;
using Modele;

namespace Test_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Pizzza");
            List<Ingredients> lIngre1 = new List<Ingredients> { (Ingredients)2, (Ingredients)20 };
            List<Ingredients> lIngre2 = new List<Ingredients> { (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza P1 = new Pizza("Reine", "Bonne", "oui", lIngre1, 15);
            Pizza P2 = new Pizza("tkt", "non", "oui", lIngre1, 102);
            Pizza P3 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Pizza P4 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Pizza P5 = new Pizza("Saucisse", "gourmande", "non", lIngre2);
            Catalogue C1 = new Catalogue();
            C1.CatalogueVegetarien.Add(P1);
            C1.CataloguePizzeta.Add(P2);
            C1.CatalogueCarnivore.Add(P3);
            C1.CatalogueEpice.Add(P4);

            Console.WriteLine(P2.Equals(P3));
            Console.WriteLine(P4.Equals(P3));

            Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3);
            Console.WriteLine(C1);
        }
    }
}
