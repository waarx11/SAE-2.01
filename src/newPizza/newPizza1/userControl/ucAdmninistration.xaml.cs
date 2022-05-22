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

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour ucAdmninistration.xaml
    /// </summary>
    public partial class ucAdmninistration : UserControl
    {
        public ucAdmninistration()
        {
            InitializeComponent();
        }

        public string setNomEntre
        {
            set
            {
                nomEntreprise.Text = value;
            }
        }

        public string setNom
        {
            set
            {
                nomGerant.Text = value;
            }
        }

        public string setEmail
        {
            set
            {
                emailEntreprise.Text = value;
            }
        }

        public string setAdresse
        {
            set
            {
                adresseEntreprise.Text = value;
            }
        }

        public string setCodePostal
        {
            set
            {
                postalEntreprise.Text = value;
            }
        }

        public string setPrenom
        {
            set
            {
                prenomGerant.Text = value;
            }
        }

        public string setTelephone
        {
            set
            {
                entrepriseTel.Text = value;
            }
        }

        public string setVille
        {
            set
            {
                entrepriseVille.Text = value;
            }
        }
    }
}
