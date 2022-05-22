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

namespace newPizzaWPF
{
    /// <summary>
    /// Logique d'interaction pour ucMenuBouton.xaml
    /// </summary>
    public partial class ucMenuBouton : UserControl
    {
        public ucMenuBouton()
        {
            InitializeComponent();
        }
        public string setMessage
        {
            set
            {
                ucBoutonMenuTEXT.Text = value;
            }
        }

        public string setImage
        {
            set
            {
                ucBoutonMenuIMG.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        public event RoutedEventHandler CLICKMENU;
        private void MenuBouton_Click(object sender, RoutedEventArgs e)
        {
            if (CLICKMENU != null)
            {
                CLICKMENU(this, e);
            }
        }
    }
}
