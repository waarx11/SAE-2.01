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
    /// Ceci est une partie du manager et il correspond a la partie Catalogue de pizza
    /// </summary>
    public partial class Manager
    {
        /// <summary>
        /// Crée un catalogue et une variable readonly qui sera égale a ce catalogue
        /// </summary>
        public readonly Catalogue Catalogues;
        public Catalogue C1 = new Catalogue();

        /// <summary>
        /// Ajouter une pizza au catalogue pizzeta vegetarien
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteCatalogueVegetarien(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueVegetarien.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueVegetarien.Add(pizz);
            return true;
        }

        /// <summary>
        /// Ajouter une pizza au catalogue pizzeta
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteCataloguePizzeta(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CataloguePizzeta.Contains(pizz))
            {
                return false;
            }
            C1.CataloguePizzeta.Add(pizz);
            return true;
        }

        /// <summary>
        /// Ajouter une pizza au catalogue carnivore
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteCatalogueCarnivore(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueCarnivore.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueCarnivore.Add(pizz);
            return true;
        }

        /// <summary>
        /// Ajouter une pizza au catalogue epice
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool AjouteCatalogueEpice(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueEpice.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueEpice.Add(pizz);
            return true;
        }

        /// <summary>
        /// Supprime une pizza au catalogue vegetarien
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppCatalogueVegetarien(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueVegetarien.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueVegetarien.Remove(pizz);
            return true;
        }

        /// <summary>
        /// Supprime une pizza au catalogue pizzeta
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppCataloguePizzeta(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CataloguePizzeta.Contains(pizz))
            {
                return false;
            }
            C1.CataloguePizzeta.Remove(pizz);
            return true;
        }

        /// <summary>
        /// Supprime une pizza au catalogue carnivore
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppCatalogueCarnivore(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueCarnivore.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueCarnivore.Remove(pizz);
            return true;
        }

        /// <summary>
        /// Supprime une pizza au catalogue epice
        /// </summary>
        /// <param name="pizz"></param>
        /// <returns>true si sa a fonctionnner false sinon</returns>
        public bool SuppCatalogueEpice(Pizza pizz)
        {
            if (pizz == null)
            {
                return false;
            }

            if (C1.CatalogueEpice.Contains(pizz))
            {
                return false;
            }
            C1.CatalogueEpice.Remove(pizz);
            return true;
        }/*

        public Catalogue GetCatalogue(Catalogue c1)
        {
            return Catalogues.SingleOrDefault(a => a.Equals(c1));
        }*/

        /// <summary>
        /// Modifie un cataloguie
        /// </summary>
        /// <param name="adOld"></param>
        /// <param name="adNew"></param>
        /// <returns>Le catalogue modifier</returns>
        public Administrateur ModifieCatalogue(Catalogue adOld, Catalogue adNew)
        {
            return null;
        }
    }
}
