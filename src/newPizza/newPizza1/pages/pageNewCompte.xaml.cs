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
        public Manager Mgr => ((App)App.Current).LeManager;
        public pageNewCompte()
        {
            InitializeComponent();
        }

        private void CloseMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonConnextion(object sender, RoutedEventArgs e)
        {
            var p = new pageIdentification();
            Close();
            p.Show();
        }

        private void ButtonInscription(object sender, RoutedEventArgs e)
        {
            int rep = Mgr.creationUtilisateur(idTextBox.Text, idMail.Text, PasswordBox.Password);
            //rien qui marche
            if (rep == 0)
            {
                message.Text = "Veuillez remplir les champs ci-dessous";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //rien qui marche
            if (rep == -1)
            {
                message.Text = "Pseudo et email deja existants";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //rien qui marche
            if (rep == -2)
            {
                message.Text = "Pseudo deja existant";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //rien qui marche
            if (rep == -3)
            {
                message.Text = "Email deja existante ou erronée";
                message.Visibility = Visibility.Visible;
                this.Show();
            }
            //rien qui marche
            if (rep == 1)
            {
                var p = new pageIdentification();
                Close();
                p.Show();
            }
        }

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            message.Visibility = Visibility.Hidden;

        }
    }
}
