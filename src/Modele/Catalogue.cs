using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Modele
{
    public class Catalogue
    {
        /// <summary>
        /// ObservableCollection des pizza présente dans le catalogueVegetarien
        /// </summary>
        private ObservableCollection<Pizza> catalogueVegetarien;
        public ObservableCollection<Pizza> CatalogueVegetarien { get => catalogueVegetarien; private set => catalogueVegetarien = value; }
        /// <summary>
        /// ObservableCollection des pizza présente dans le cataloguePizzeta
        /// </summary>
        private ObservableCollection<Pizza> cataloguePizzeta;
        public ObservableCollection<Pizza> CataloguePizzeta { get => cataloguePizzeta; private set => cataloguePizzeta = value; }
        /// <summary>
        /// ObservableCollection des pizza présente dans le catalogueCarnivore
        /// </summary>
        private ObservableCollection<Pizza> catalogueCarnivore;
        public ObservableCollection<Pizza> CatalogueCarnivore { get => catalogueCarnivore; private set => catalogueCarnivore = value; }
        /// <summary>
        /// ObservableCollection des pizza présente dans le catalogueEpice
        /// </summary>
        private ObservableCollection<Pizza> catalogueEpice;
        public ObservableCollection<Pizza> CatalogueEpice { get => catalogueEpice; private set => catalogueEpice = value; }

        /// <summary>
        /// Construteur de la classe catalogue, crée 4 ObservableCollection
        /// </summary>
        public Catalogue()
        { 
            catalogueVegetarien = new ObservableCollection<Pizza>();
            cataloguePizzeta = new ObservableCollection<Pizza>();
            catalogueCarnivore = new ObservableCollection<Pizza>();
            catalogueEpice = new ObservableCollection<Pizza>();
        }

        /// <summary>
        /// Affiche un catalogue précis préciser en paramètre
        /// </summary>
        /// <param name="other"></param>
        public void afficheCatPrecis(ObservableCollection<Pizza> other)
        {
            if(Equals(other))
            {
                foreach (Pizza p1 in other)
                {
                    p1.ToString();
                }
            }
        }

        /// <summary>
        /// Permet de savoir si le catalogue passer en paramètre existe déjà ou non
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true si le catalogue existe, false sinon</returns>
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
