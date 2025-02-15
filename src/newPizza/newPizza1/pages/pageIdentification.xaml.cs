﻿using System;
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
using System.Windows.Shapes;
using Modele;
namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageIdentification.xaml
    /// </summary>
    public partial class pageIdentification : Window
    {
        /// <summary>
        /// Appel du manager
        /// </summary>
        public Manager Mgr => ((App)App.Current).LeManager;

        /// <summary>
        /// Initialise & vérification du thème
        /// </summary>
        public pageIdentification()
        {
            InitializeComponent();
            object v = Application.Current.Resources["couleurPrincipale"];
            if (v.ToString() == "#FF68A7AD")
                BtnTheme.Content = "Thème : Clair";
            else
                BtnTheme.Content = "Thème : Sombre";
        }

        /// <summary>
        /// Bouton fermeture du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Changement du thème
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeColorGlobal(object sender, RoutedEventArgs e)
        {
            object v = Application.Current.Resources["couleurPrincipale"];
            if (BtnTheme.Content.ToString() == "Thème : Clair")
            {
                Application.Current.Resources["couleurPrincipale"] = new SolidColorBrush(Color.FromRgb(75, 72, 72));
                Application.Current.Resources["couleurSecondaire"] = new SolidColorBrush(Color.FromRgb(83, 82, 81));
                Application.Current.Resources["couleurArrierePlan"] = new SolidColorBrush(Color.FromRgb(142, 140, 140));
                Application.Current.Resources["couleurTexte"] = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Application.Current.Resources["couleurFond"] = new SolidColorBrush(Color.FromRgb(115, 110, 110));
                BtnTheme.Content = "Thème : Sombre";
            }
            else
            {
                Application.Current.Resources["couleurPrincipale"] = new SolidColorBrush(Color.FromRgb(104, 167, 173));
                Application.Current.Resources["couleurSecondaire"] = new SolidColorBrush(Color.FromRgb(77, 141, 147));
                Application.Current.Resources["couleurArrierePlan"] = new SolidColorBrush(Color.FromRgb(61, 155, 174));
                Application.Current.Resources["couleurTexte"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                Application.Current.Resources["couleurFond"] = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                BtnTheme.Content = "Thème : Clair";
            }

        }

        /// <summary>
        /// Bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            int rep=Mgr.connecterUtilisateur(idTextBox.Text,PasswordBox.Password);
            //rien qui marche
            if (rep == -1)
            {
                message.Text = "Identifiant ou mot de passe incorrect !";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //admin peut ce connecter
            if (rep == 1)
            {
                pageAdministrateur p =new pageAdministrateur();
                this.Close();
                p.Show();
            }
            //admin mot de passe faux
            if (rep == 2)
            {
                message.Text = "Identifiant ou mot de passe incorrect !";
                message.Visibility = Visibility.Visible;    
                this.Show();
            }
            //client peut ce connecter
            if (rep == 3)
            {
                pageCatalogue pClinet =new pageCatalogue();
                this.Close();
                pClinet.Show();
            }
            //client mot de passe faux
            if (rep == 4)
            {
                message.Text = "Identifiant ou mot de passe incorrect !";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
        }

        /// <summary>
        /// Message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }
        /// <summary>
        /// Message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }
        /// <summary>
        /// Page d'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCompte(object sender, RoutedEventArgs e)
        {
            var p = new pageNewCompte();
            Close();
            p.Show();
        }
    }
}
