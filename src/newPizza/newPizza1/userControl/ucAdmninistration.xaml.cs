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
    /// Logique d'interaction pour ucAdmninistration.xaml
    /// </summary>
    public partial class ucAdmninistration : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public ucAdmninistration()
        {
            InitializeComponent();
            DataContext = Mgr.UtilisateurActuel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nom, prénom, email, téléphone, adresse, ville, codePostal;
            nom = idNomGerant.Text;
            prénom = idPrenomGerant.Text;
            email = idEmailEntreprise.Text;
            téléphone = idEntrepriseTel.Text;
            adresse = idAdresseEntreprise.Text;
            ville = idEntrepriseVille.Text;
            codePostal = idPostalEntreprise.Text;

            if (string.IsNullOrWhiteSpace(nom))
            {
                nom = Mgr.UtilisateurActuel.Nom;
            }
            if (string.IsNullOrWhiteSpace(prénom))
            {
                prénom = Mgr.UtilisateurActuel.Prénom;
            }
            if ((!email.Contains("@") || string.IsNullOrWhiteSpace(email)))
            {
                email = Mgr.UtilisateurActuel.Email;
            }
            if (string.IsNullOrWhiteSpace(téléphone))
            {
                téléphone = Mgr.UtilisateurActuel.Téléphone;
            }
            if (string.IsNullOrWhiteSpace(adresse))
            {
                adresse = Mgr.UtilisateurActuel.Adresse;
            }
            if (string.IsNullOrWhiteSpace(ville))
            {
                ville = Mgr.UtilisateurActuel.Ville;
            }
            if (string.IsNullOrWhiteSpace(codePostal))
            {
                codePostal = Mgr.UtilisateurActuel.CodePostal;
            }
            Mgr.UtilisateurActuel = Mgr.UtilisateurActuel.EnregistrerModif(nom, prénom, email, téléphone, adresse, ville, codePostal);
        }
    }
}
