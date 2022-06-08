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
        }


        public string setNom
        {
            set
            {
                NomPizza.Text = value;
            }
        }

        public string setDescription
        {
            set
            {
                DescriptionPizza.Text = value;
            }
        }

        public string setPrix
        {
            set
            {
                PrixPizza.Text = value;
            }
        }



        public string setImage
        {
            set
            {
                Image.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

    }
}
