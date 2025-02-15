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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour ucMenuBouton.xaml
    /// </summary>
    public partial class ucMenuBouton : UserControl
    {

        /// <summary>
        /// initialise
        /// </summary>
        public ucMenuBouton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// change le message
        /// </summary>
        public string setMessage
        {
            set
            {
                ucBoutonMenuTEXT.Text = value;
            }
        }

        /// <summary>
        /// Evenement bouton
        /// </summary>
        public event RoutedEventHandler? CLICKMENU;
        private void MenuBouton_Click(object sender, RoutedEventArgs e)
        {
            if (CLICKMENU != null)
            {
                CLICKMENU(this, e);
            }
        }
    }
}
