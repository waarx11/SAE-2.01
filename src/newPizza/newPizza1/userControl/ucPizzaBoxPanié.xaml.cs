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
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                if (m > 1)
                {
                    m += 1;
                    Mgr.PizzaActuelle.Quantité = m;
                }
            }
        }

        public void BtnMoin(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                if (m > 1)
                {
                    m -= 1;
                    Mgr.PizzaActuelle.Quantité = m;
                }
            }
        }

        public void rmPanier(object sender, RoutedEventArgs e)
        {
            if (((Client)Mgr.UtilisateurActuel).ListPizzaClient.Count <= 1)
                ((Client)Mgr.UtilisateurActuel).ListPizzaClient = new List<Pizza>();
            else
            {
                List<Pizza> Piz = new List<Pizza>();
                ((Client)Mgr.UtilisateurActuel).ListPizzaClient.Remove(Mgr.PizzaActuelle);
                foreach (Pizza list in ((Client)Mgr.UtilisateurActuel).ListPizzaClient)
                {
                    Piz.Add(list);
                }
                ((Client)Mgr.UtilisateurActuel).ListPizzaClient = new List<Pizza>(Piz);
            }
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



        public int QtePizza
        {
            get { return (int)GetValue(QtePizzaProperty); }
            set { SetValue(QtePizzaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QtePizza.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QtePizzaProperty =
            DependencyProperty.Register("QtePizza", typeof(int), typeof(ucPizzaBoxPanié), new PropertyMetadata(1));


    }
}
