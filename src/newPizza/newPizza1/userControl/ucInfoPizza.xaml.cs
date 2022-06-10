using Modele;
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

        public Manager Mgr => ((App)App.Current).LeManager;

        public ucInfoPizza()
        {
            InitializeComponent();
            DataContext = Mgr.PizzaActuelle;
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(ucInfoPizza), new PropertyMetadata("noImg.png"));


    }
}
