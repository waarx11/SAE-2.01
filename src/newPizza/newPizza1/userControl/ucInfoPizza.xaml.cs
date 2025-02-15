﻿using Modele;
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
    /// Logique d'interaction pour ucInfoPizza.xaml
    /// </summary>
    public partial class ucInfoPizza : UserControl
    {
        /// <summary>
        /// appel du manager
        /// </summary>
        public Manager Mgr => ((App)App.Current).LeManager;

        /// <summary>
        /// Initialise & récupère la pizza actuelle
        /// </summary>
        public ucInfoPizza()
        {
            InitializeComponent();
            DataContext = Mgr.PizzaActuelle;
        }

        /// <summary>
        /// Bouton +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnPlus(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                Mgr.PizzaActuelle.Quantité = m + 1;
            }
        }
        /// <summary>
        /// Bouton -
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Ajouter au panier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddPanier(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                if (m >= 1)
                {
                    ((Client)Mgr.UtilisateurActuel).ajouterPizzaCommande(Mgr.PizzaActuelle);
                    ((Client)Mgr.UtilisateurActuel).ListPizzaClient[((Client)Mgr.UtilisateurActuel).ListPizzaClient.Count() - 1].Quantité = Mgr.PizzaActuelle.modifQte(m);
                }
            }
        }
    }
}
