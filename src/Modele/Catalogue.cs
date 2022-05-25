using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Modele
{
    public class Catalogue
    {
        /// <summary>
        /// List des pizza présente dans le catalogueVegetarien
        /// </summary>
        private ObservableCollection<Pizza> catalogueVegetarien;
        public ObservableCollection<Pizza> CatalogueVegetarien { get => catalogueVegetarien; private set => catalogueVegetarien = value; }
        /// <summary>
        /// List des pizza présente dans le cataloguePizzeta
        /// </summary>
        private List<Pizza> cataloguePizzeta;
        public List<Pizza> CataloguePizzeta { get => cataloguePizzeta; private set => cataloguePizzeta = value; }
        /// <summary>
        /// List des pizza présente dans le catalogueCarnivore
        /// </summary>
        private List<Pizza> catalogueCarnivore;
        public List<Pizza> CatalogueCarnivore { get => catalogueCarnivore; private set => catalogueCarnivore = value; }
        /// <summary>
        /// List des pizza présente dans le catalogueEpice
        /// </summary>
        private List<Pizza> catalogueEpice;
        public List<Pizza> CatalogueEpice { get => catalogueEpice; private set => catalogueEpice = value; }

        public Catalogue()
        { 
            catalogueVegetarien = new ObservableCollection<Pizza>();
            cataloguePizzeta = new List<Pizza>();
            catalogueCarnivore = new List<Pizza>();
            catalogueEpice = new List<Pizza>();
        }

        public void afficheCatPrecis(List<Pizza> other)
        {
            if(Equals(other))
            {
                foreach (Pizza p1 in other)
                {
                    p1.ToString();
                }
            }
        }
        public bool Equals(Catalogue other)
        {
            return catalogueVegetarien == other.catalogueVegetarien || cataloguePizzeta == other.cataloguePizzeta || catalogueCarnivore == other.catalogueCarnivore || catalogueEpice == other.catalogueEpice;
        }

        public override string ToString()
        {
            string Afficher = "";
            Afficher += "Voici les pizza présente dans catalogue des Vegetarien : \n";
            foreach (Pizza element in catalogueVegetarien)
            {
                Afficher += $"{element} ";
            }
            Afficher += "\n\n";
            Afficher += "Voici les pizza présente dans catalogue des Pizzeta : \n";
            foreach (Pizza element in cataloguePizzeta)
            {
                Afficher += $"{element} ";
            }
            Afficher += "\n\n";
            Afficher += "Voici les pizza présente dans catalogue des Carnivores : \n";
            foreach (Pizza element in catalogueCarnivore)
            {
                Afficher += $"{element} ";
            }
            Afficher += "\n\n";
            Afficher += "Voici les pizza présente dans catalogue des Epices : \n";
            foreach (Pizza element in catalogueEpice)
            {
                Afficher += $"{element} ";
            }

            return Afficher;
        }
    }
}
