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
    /// Logique d'interaction pour ucPizzaBox.xaml
    /// </summary>
    public partial class ucPizzaBox : UserControl
    {
        public ucPizzaBox()
        {
            InitializeComponent();
        }

        public string setNomPizza
        {
            set
            {
                nomPizza.Text = value;
            }
        }

        public string setImage
        {
            set
            {
                imgPizza.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }
    }
}
