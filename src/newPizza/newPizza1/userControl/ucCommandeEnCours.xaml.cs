using Modele;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour ucCommandeEnCours.xaml
    /// </summary>
    public partial class ucCommandeEnCours : UserControl
    {
        public Manager Mgr => ((App)App.Current).LeManager;
        public ucCommandeEnCours()
        {
            InitializeComponent();
        }


        public string nomPizz
        {
            get { return (string)GetValue(nomPizzProperty); }
            set { SetValue(nomPizzProperty, value); }
        }

        // Using a DependencyProperty as the backing store for nomPizz.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nomPizzProperty =
            DependencyProperty.Register("nomPizz", typeof(string), typeof(ucCommandeEnCours), new PropertyMetadata("Inconnue"));



        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(ucCommandeEnCours), new PropertyMetadata(""));



        public int qtePiz
        {
            get { return (int)GetValue(qtePizProperty); }
            set { SetValue(qtePizProperty, value); }
        }

        // Using a DependencyProperty as the backing store for qtePiz.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty qtePizProperty =
            DependencyProperty.Register("qtePiz", typeof(int), typeof(ucCommandeEnCours), new PropertyMetadata(1));



        public string TextDes
        {
            get { return (string)GetValue(TextDesProperty); }
            set { SetValue(TextDesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextDes.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextDesProperty =
            DependencyProperty.Register("TextDes", typeof(string), typeof(ucCommandeEnCours), new PropertyMetadata("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam."));


    }
}
