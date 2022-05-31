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
    /// Logique d'interaction pour pageMonPanier.xaml
    /// </summary>
    public partial class pageMonPanier : Window
    {
        public pageMonPanier()
        {
            InitializeComponent();
        }

        public void RetourWindow(object sender, RoutedEventArgs e)
        {
            pageCatalogue pClinet = new pageCatalogue();
            this.Close();
            pClinet.Show();
        }

        public void DecoWindow(object sender, RoutedEventArgs e)
        {
            pageIdentification identif = new pageIdentification();
            this.Close();
            identif.Show();
        }

        public string Photo
        {
            get { return (string)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Photo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhotoProperty =
            DependencyProperty.Register("Photo", typeof(string), typeof(pageMonPanier), new PropertyMetadata("..\\img\\default\\noPP.jpg"));


        public string Pseudo
        {
            get { return (string)GetValue(PseudoProperty); }
            set { SetValue(PseudoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Pseudo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PseudoProperty =
            DependencyProperty.Register("Pseudo", typeof(string), typeof(pageMonPanier), new PropertyMetadata("Erreur de récupération"));

    }
}
