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
using System.Windows.Shapes;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageMonPanier.xaml
    /// </summary>
    public partial class pageMonPanier : Window
    {
        public Manager Mgr => ((App)App.Current).LeManager;

        public pageMonPanier()
        {
            DataContext = (Mgr.UtilisateurActuel as Client);
            InitializeComponent();
            int prixT = 0;
            foreach ( Pizza val in ((Client)Mgr.UtilisateurActuel).ListPizzaClient)
            {
                prixT += (val.Prix * val.Quantité);
            }
            PrixTotal.Text= prixT.ToString();
        }

        public void RetourWindow(object sender, RoutedEventArgs e)
        {
            pageCatalogue pClinet = new pageCatalogue();
            this.Close();
            pClinet.Show();
        }

        public void DecoWindow(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter", "Déconnexion", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                pageIdentification identif = new pageIdentification();
                this.Close();
                identif.Show();
            }
        }

        public string Photo
        {
            get { return (string)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Photo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhotoProperty =
            DependencyProperty.Register("Photo", typeof(string), typeof(pageMonPanier), new PropertyMetadata("..\\img\\default\\noPP.jpg"));


        public string Pseudo
        {
            get { return (string)GetValue(PseudoProperty); }
            set { SetValue(PseudoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Pseudo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PseudoProperty =
            DependencyProperty.Register("Pseudo", typeof(string), typeof(pageMonPanier), new PropertyMetadata("Erreur de récupération"));

        public int ChoixPaiement { get; set; }

        private void SlctPaypal(object sender, RoutedEventArgs e)
        {
            paypal.Foreground = new SolidColorBrush(Colors.Red);
            cb.Foreground = new SolidColorBrush(Colors.Black);
            ChoixPaiement = 1;
        }


        private void SlctCB(object sender, RoutedEventArgs e)
        {
            cb.Foreground = new SolidColorBrush(Colors.Red);
            paypal.Foreground = new SolidColorBrush(Colors.Black);
            ChoixPaiement = 2;
        }

        private void Paid(object sender, RoutedEventArgs e)
        {
            if (ChoixPaiement != 1 && ChoixPaiement != 2)
            {
                return;
            }
            else
            {
                if (ChoixPaiement == 1)
                {
                    MessageBox.Show("Vous venez de payer avec Paypal, votre commande a été transmise pour être préparée", "Commande validée", MessageBoxButton.OK);
                }
                if (ChoixPaiement == 2)
                {
                    MessageBox.Show("Vous venez de payer par Carte Bancaire, votre commande a été transmise pour être préparée", "Commande validée", MessageBoxButton.OK);
                }
                Commande C1 = new Commande(((Client)Mgr.UtilisateurActuel), ((Client)Mgr.UtilisateurActuel).ListPizzaClient);
                ((Client)Mgr.UtilisateurActuel).envoyerListeCommande(C1,(Administrateur)Mgr.Administrateurs.First());
            }

        }
        
    }
}
