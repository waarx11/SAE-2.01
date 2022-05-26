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

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageNewCompte.xaml
    /// </summary>
    public partial class pageNewCompte : Window
    {
        public pageNewCompte()
        {
            InitializeComponent();
        }

        private void CloseMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonConnextion(object sender, RoutedEventArgs e)
        {
            var p = new pageIdentification();
            Close();
            p.Show();
        }

    }
}
