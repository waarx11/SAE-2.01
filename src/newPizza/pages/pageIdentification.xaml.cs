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
    /// Logique d'interaction pour pageIdentification.xaml
    /// </summary>
    public partial class pageIdentification : Window
    {
        public pageIdentification()
        {
            InitializeComponent();
        }
        private void CloseMenu(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void changeColorGlobal(object sender, RoutedEventArgs e)
        {
            if (BtnTheme.Content.ToString() == "Thème : Clair")
            {
                Application.Current.Resources["couleurPrincipale"] = new SolidColorBrush(Color.FromRgb(75, 72, 72));
                Application.Current.Resources["couleurSecondaire"] = new SolidColorBrush(Color.FromRgb(115, 110, 110));
                Application.Current.Resources["couleurArrierePlan"] = new SolidColorBrush(Color.FromRgb(142, 140, 140));
                BtnTheme.Content = "Thème : Sombre";
            }
            else
            {
                Application.Current.Resources["couleurPrincipale"] = new SolidColorBrush(Color.FromRgb(104, 167, 173));
                Application.Current.Resources["couleurSecondaire"] = new SolidColorBrush(Color.FromRgb(77, 141, 147));
                Application.Current.Resources["couleurArrierePlan"] = new SolidColorBrush(Color.FromRgb(61, 155, 174));
                BtnTheme.Content = "Thème : Clair";
            }

        }
    }
}
