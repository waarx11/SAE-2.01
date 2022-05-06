using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Catalogue
    {

        List<Pizza> CatalogueVegetarien = new List<Pizza>();
        List<Pizza> CataloguePizzeta = new List<Pizza>();
        List<Pizza> CatalogueCarnivore = new List<Pizza>();
        List<Pizza> CatalogueEpice = new List<Pizza>();

        public Catalogue()
        { }

        public void ajoutePizzaCatVege(Pizza pizza)
        {
            CatalogueVegetarien.Add(pizza);
        }

        public void ajoutePizzaCatPizzeta(Pizza pizza)
        {
            CataloguePizzeta.Add(pizza);
        }

        public void ajoutePizzaCatCarni(Pizza pizza)
        {
            CatalogueCarnivore.Add(pizza);
        }

        public void ajoutePizzaCatEpice(Pizza pizza)
        {
            CatalogueEpice.Add(pizza);
        }

        /*public override string ToString()
        {
            foreach (int element in fibNumbers)
            {
                Console.Write($"{} ");
            })
        }*/
    }
}
