using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 

    public partial class pageCatalogue : Window
    {
        public Manager Mgr => ((App)App.Current).LeManager;
        public pageCatalogue()
        {
            InitializeComponent();
        }
        private void MenuBouton_Pizzetas(object sender, RoutedEventArgs e)
        {
            ccCatalogue.Content = new ucCataloguePizzeta();
        }

        private void MenuBouton_Epicees(object sender, RoutedEventArgs e)
        {
            ccCatalogue.Content = new ucCatalogueEpicees();
        }

        private void MenuBouton_Carnivores(object sender, RoutedEventArgs e)
        {
            ccCatalogue.Content = new ucCatalogueCarnivore();
        }

        private void MenuBouton_Vegetariennes(object sender, RoutedEventArgs e)
        {
            ccCatalogue.Content = new ucCatalogueVege();
        }

        private void MenuBouton_Deconnexion(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Déconnexion", "Voulez-vous vraiment vous  déconnecter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                pageIdentification identif = new pageIdentification();
                this.Close();
                identif.Show();
            }
        }

    }
}
