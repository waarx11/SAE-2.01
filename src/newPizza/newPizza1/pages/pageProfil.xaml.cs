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
            pageCatalogue catalo = new pageCatalogue();
            this.Close();
            catalo.Show();
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
            DependencyProperty.Register("Photo", typeof(string), typeof(pageProfil), new PropertyMetadata("..\\img\\default\\noPP.jpg"));


    }
}
