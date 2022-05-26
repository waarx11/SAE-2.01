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
    /// Logique d'interaction pour pageProfil.xaml
    /// </summary>
    public partial class pageProfil : Window
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public pageProfil()
        {
            DataContext = Mgr.UtilisateurActuel;
            InitializeComponent();
        }

        public void RetourWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void DecoWindow(object sender, RoutedEventArgs e)
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

    }
}
