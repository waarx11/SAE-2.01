using System;
using Modele;

namespace Test_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Pizzza");

            Pizza P1 = new Pizza("Reine", "Bonne", "oui", 15);
            Pizza P2 = new Pizza("tkt", "non", "oui", 102);
            Pizza P3 = new Pizza("Saucisse", "gourmande", "non");
            Pizza P4 = new Pizza("Saucisse", "gourmande", "non");
            Catalogue C1 = new Catalogue();
            C1.CatalogueVegetarien.Add(P1);
            C1.CataloguePizzeta.Add(P2);
            C1.CatalogueCarnivore.Add(P3);
            C1.CatalogueEpice.Add(P4);


            Console.WriteLine(C1);
        }
    }
}
