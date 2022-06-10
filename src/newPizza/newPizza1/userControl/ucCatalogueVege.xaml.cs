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
    /// Logique d'interaction pour ucCatalogueVege.xaml
    /// </summary>
    public partial class ucCatalogueVege : UserControl
    {
        /// <summary>
        /// appel du manager
        /// </summary>
        public Manager Mgr => ((App)App.Current).LeManager;

        /// <summary>
        /// initialise & récupère le manager
        /// </summary>

        public ucCatalogueVege()
        {
            DataContext = Mgr;
            InitializeComponent();
        }

        /// <summary>
        /// Evenement bouton
        /// </summary>
        public event RoutedEventHandler? CLICKVEGE;
        private void MenuBouton_Click(object sender, RoutedEventArgs e)
        {
            if (CLICKVEGE != null)
            {
                CLICKVEGE(this, e);
            }
        }

    }
}
