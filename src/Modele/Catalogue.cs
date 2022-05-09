using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Catalogue
    {

        private List<Pizza> catalogueVegetarien;
        public List<Pizza> CatalogueVegetarien { get => catalogueVegetarien; set => catalogueVegetarien = value; }

        private List<Pizza> cataloguePizzeta;
        public List<Pizza> CataloguePizzeta { get => cataloguePizzeta; set => cataloguePizzeta = value; }

        private List<Pizza> catalogueCarnivore;
        public List<Pizza> CatalogueCarnivore { get => catalogueCarnivore; set => catalogueCarnivore = value; }

        private List<Pizza> catalogueEpice;
        public List<Pizza> CatalogueEpice { get => catalogueEpice; set => catalogueEpice = value; }

        public Catalogue()
        { 
            catalogueVegetarien = new List<Pizza>();
            cataloguePizzeta = new List<Pizza>();
            catalogueCarnivore = new List<Pizza>();
            catalogueEpice = new List<Pizza>();
        }

        public void ajoutePizzaCatVege(Pizza pizza)
        {
            catalogueVegetarien.Add(pizza);
        }

        public void ajoutePizzaCatPizzeta(Pizza pizza)
        {
            cataloguePizzeta.Add(pizza);
        }

        public void ajoutePizzaCatCarni(Pizza pizza)
        {
            catalogueCarnivore.Add(pizza);
        }

        public void ajoutePizzaCatEpice(Pizza pizza)
        {
            catalogueEpice.Add(pizza);
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
