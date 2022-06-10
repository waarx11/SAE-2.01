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
using System.Windows.Shapes;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageNewCompte.xaml
    /// </summary>
    public partial class pageNewCompte : Window
    {
        /// <summary>
        /// Appel du manager
        /// </summary>
        public Manager Mgr => ((App)App.Current).LeManager;

        /// <summary>
        /// Initialise
        /// </summary>
        public pageNewCompte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ferme la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Redirige vers la page connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnextion(object sender, RoutedEventArgs e)
        {
            var p = new pageIdentification();
            Close();
            p.Show();
        }

        /// <summary>
        /// Bouton Inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInscription(object sender, RoutedEventArgs e)
        {
            int rep = Mgr.creationUtilisateur(idTextBox.Text, idMail.Text, PasswordBox.Password);
            //Rien remplie
            if (rep == 0)
            {
                message.Text = "Veuillez remplir les champs ci-dessous";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //Pseudo et email existant
            if (rep == -1)
            {
                message.Text = "Pseudo et email deja existants";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //Pseudo deja existant
            if (rep == -2)
            {
                message.Text = "Pseudo deja existant";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //Email incorrect
            if (rep == -3)
            {
                message.Text = "Email deja existante ou erronée";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //Sa marche
            if (rep == 1)
            {
                var p = new pageIdentification();
                Mgr.SauvegardeDonnées();
                Close();
                p.Show();
            }
        }

        /// <summary>
        /// message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }

        /// <summary>
        /// message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }
    }
}
