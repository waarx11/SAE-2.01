using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            ctPizzeta.Visibility = Visibility.Visible;
            ctCarnivore.Visibility = Visibility.Hidden;
            ctEpicee.Visibility = Visibility.Hidden;
            ctVege.Visibility = Visibility.Hidden;
            ccCatalogue.Visibility = Visibility.Hidden;
        }
        private void MenuBouton_Epicees(object sender, RoutedEventArgs e)
        {
            ctPizzeta.Visibility = Visibility.Hidden;
            ctCarnivore.Visibility = Visibility.Hidden;
            ctEpicee.Visibility = Visibility.Visible;
            ctVege.Visibility = Visibility.Hidden;
            ccCatalogue.Visibility = Visibility.Hidden;
        }

        private void MenuBouton_Carnivores(object sender, RoutedEventArgs e)
        {
            ctPizzeta.Visibility = Visibility.Hidden;
            ctCarnivore.Visibility = Visibility.Visible;
            ctEpicee.Visibility = Visibility.Hidden;
            ctVege.Visibility = Visibility.Hidden;
            ccCatalogue.Visibility = Visibility.Hidden;
        }

        private void MenuBouton_Vegetariennes(object sender, RoutedEventArgs e)
        {
            ctPizzeta.Visibility = Visibility.Hidden;
            ctCarnivore.Visibility = Visibility.Hidden;
            ctEpicee.Visibility = Visibility.Hidden;
            ctVege.Visibility = Visibility.Visible;
            ccCatalogue.Visibility = Visibility.Hidden;
        }

        private void MenuBouton_Deconnexion(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter", "Déconnexion", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                pageIdentification identif = new pageIdentification();
                this.Close();
                identif.Show();
            }
        }

        private void PlusInfo(object sender, RoutedEventArgs e)
        {
            ctPizzeta.Visibility = Visibility.Hidden;
            ctCarnivore.Visibility = Visibility.Hidden;
            ctEpicee.Visibility = Visibility.Hidden;
            ctVege.Visibility = Visibility.Hidden;
            ccCatalogue.Visibility = Visibility.Visible;
            ccCatalogue.Content = new ucInfoPizza();
        }

    }
}
