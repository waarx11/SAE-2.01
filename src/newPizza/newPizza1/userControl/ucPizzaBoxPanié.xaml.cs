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
    /// Logique d'interaction pour ucPizzaBoxPanié.xaml
    /// </summary>
    public partial class ucPizzaBoxPanié : UserControl
    {
        public Manager Mgr => ((App)App.Current).LeManager;
        public ucPizzaBoxPanié()
        {
            InitializeComponent();
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

        public void rmPanier(object sender, RoutedEventArgs e)
        {
            if ((Mgr.UtilisateurActuel as Client).ListPizzaClient.Count <= 1)
                (Mgr.UtilisateurActuel as Client).ListPizzaClient.Clear();
            else
                (Mgr.UtilisateurActuel as Client).ListPizzaClient.Remove(Mgr.PizzaActuelle);
        }

        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(ucPizzaBoxPanié), new PropertyMetadata("Soy una pizza"));



        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(ucPizzaBoxPanié), new PropertyMetadata("nolmg.png"));
    }
}
