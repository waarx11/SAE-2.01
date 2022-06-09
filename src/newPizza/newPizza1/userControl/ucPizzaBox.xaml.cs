using Modele;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour ucPizzaBox.xaml
    /// </summary>
    public partial class ucPizzaBox : UserControl
    {

        public Manager Mgr => ((App)App.Current).LeManager;

        public ucPizzaBox()
        {
            InitializeComponent();
        }

        public void BTN_PLUS_DINFO(object sender, RoutedEventArgs e)
        {
            var plusInfo = new ucInfoPizza();
            //contControl.Content = plusInfo;
        }

        public void BtnPlus(object sender, RoutedEventArgs e)
        {
            int m = Int32.Parse(TextB.Text);
            m += 1;
            TextB.Text = m.ToString();
        }

        public void BtnMoin(object sender, RoutedEventArgs e)
        {
            int m = Int32.Parse(TextB.Text);
            if (m > 1)
            {
                m -= 1;
                TextB.Text = m.ToString();
            }
        }

        public void AddPanier(object sender, RoutedEventArgs e)
        {
            (Mgr.UtilisateurActuel as Client).ListPizzaClient.Add(Mgr.SelectedPizza);
            int m = Int32.Parse(TextB.Text);
        }

        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(ucPizzaBox), new PropertyMetadata("Soy una pizza"));

        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(ucPizzaBox), new PropertyMetadata("nolmg.png"));

        private void btnPlusInfo(object sender, RoutedEventArgs e)
        {
            // Récupérer la pizza cliquée :
            //int rep = Mgr.selectionnerPizza(/*mettre le nom ici*/);
            
            // Récupérer la page actuelle & pageCatalogue:
            //Catalogue pageCatalogue = ..........; a completer
            
            // Lancer le uc:
            //pageCatalogue.ccCatalogue.Content = new ucInfoPizza(); ou qqc du genre
            
            // Mettre les bonnes info dans le binding
            // - setImage
            // - setNom
            // - setDescription
            // - setPrix
        }
    }
}
