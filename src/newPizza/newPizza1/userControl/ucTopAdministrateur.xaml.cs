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
    /// Logique d'interaction pour ucTopAdministrateur.xaml
    /// </summary>
    public partial class ucTopAdministrateur : UserControl
    {
        public ucTopAdministrateur()
        {
            InitializeComponent();
        }

        public string setInfo
        {
            set
            {
                pourQui.Text = value;
            }
        }

        public string TextNomEnt
        {
            get { return (string)GetValue(TextNomEntProperty); }
            set { SetValue(TextNomEntProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextNomEnt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextNomEntProperty =
            DependencyProperty.Register("TextNomEnt", typeof(string), typeof(ucTopAdministrateur), new PropertyMetadata("A renseigner"));

    }
}
