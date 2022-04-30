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

namespace newPizza
{
    /// <summary>
    /// Logique d'interaction pour pageAdministrateur.xaml
    /// </summary>
    public partial class pageAdministrateur : Window
    {
        public pageAdministrateur()
        {
            InitializeComponent();
        }

        private void Bouton_Deconnexion(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
