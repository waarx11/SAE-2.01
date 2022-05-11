using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Catalogue
    {
        /// <summary>
        /// List des pizza présente dans le catalogueVegetarien
        /// </summary>
        private List<Pizza> catalogueVegetarien;
        public List<Pizza> CatalogueVegetarien { get => catalogueVegetarien; set => catalogueVegetarien = value; }
        /// <summary>
        /// List des pizza présente dans le cataloguePizzeta
        /// </summary>
        private List<Pizza> cataloguePizzeta;
        public List<Pizza> CataloguePizzeta { get => cataloguePizzeta; set => cataloguePizzeta = value; }
        /// <summary>
        /// List des pizza présente dans le catalogueCarnivore
        /// </summary>
        private List<Pizza> catalogueCarnivore;
        public List<Pizza> CatalogueCarnivore { get => catalogueCarnivore; set => catalogueCarnivore = value; }
        /// <summary>
        /// List des pizza présente dans le catalogueEpice
        /// </summary>
        private List<Pizza> catalogueEpice;
        public List<Pizza> CatalogueEpice { get => catalogueEpice; set => catalogueEpice = value; }

        public Catalogue()
        { 
            catalogueVegetarien = new List<Pizza>();
            cataloguePizzeta = new List<Pizza>();
            catalogueCarnivore = new List<Pizza>();
            catalogueEpice = new List<Pizza>();
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
