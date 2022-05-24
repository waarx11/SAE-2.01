using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Modele
{
    public partial class Manager
    {
        public readonly Catalogue Catalogues;
        public Catalogue C1 = new Catalogue();

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
        }

        public Catalogue GetCatalogue(Catalogue c1)
        {
            return Catalogues.SingleOrDefault(a => a.Equals(c1));
        }

        public Administrateur ModifieCatalogue(Catalogue adOld, Catalogue adNew)
        {
            return null;
        }
    }
}
