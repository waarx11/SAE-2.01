using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; private set; } = new Manager(new DataContractPersistance.DataContractPers());
        
        public App() :base()
        {
            LeManager.ChargeDonnées();
        }

        public void App_end(object sender, ExitEventArgs e)
        {
            foreach (var catVe in LeManager.C1.CatalogueVegetarien)
            {
                catVe.Quantité = 1;
            }
            foreach (var catEp in LeManager.C1.CatalogueEpice)
            {
                catEp.Quantité = 1;
            }
            foreach (var catCa in LeManager.C1.CatalogueCarnivore)
            {
                catCa.Quantité = 1;
            }
            foreach (var catV in LeManager.C1.CataloguePizzeta)
            {
                catV.Quantité = 1;
            }

            LeManager.SauvegardeDonnées();
        }
    }
}
