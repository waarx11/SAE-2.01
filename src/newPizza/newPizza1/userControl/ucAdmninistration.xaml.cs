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
    /// Logique d'interaction pour ucAdmninistration.xaml
    /// </summary>
    public partial class ucAdmninistration : UserControl
    {
        public ucAdmninistration()
        {
            InitializeComponent();
        }

        public string TextName
        {
            get { return (string)GetValue(TextNameProperty); }
            set { SetValue(TextNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextNameProperty =
            DependencyProperty.Register("TextName", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextEMail
        {
            get { return (string)GetValue(TextEMailProperty); }
            set { SetValue(TextEMailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextEMail.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextEMailProperty =
            DependencyProperty.Register("TextEMail", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextAdresse
        {
            get { return (string)GetValue(TextAdresseProperty); }
            set { SetValue(TextAdresseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextAdresse.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextAdresseProperty =
            DependencyProperty.Register("TextAdresse", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextCodeP
        {
            get { return (string)GetValue(TextCodePProperty); }
            set { SetValue(TextCodePProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextCodeP.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextCodePProperty =
            DependencyProperty.Register("TextCodeP", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextPrenom
        {
            get { return (string)GetValue(TextPrenomProperty); }
            set { SetValue(TextPrenomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextPrenom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextPrenomProperty =
            DependencyProperty.Register("TextPrenom", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextTelephone
        {
            get { return (string)GetValue(TextTelephoneProperty); }
            set { SetValue(TextTelephoneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextTelephone.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextTelephoneProperty =
            DependencyProperty.Register("TextTelephone", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));


        public string TextVille
        {
            get { return (string)GetValue(TextVilleProperty); }
            set { SetValue(TextVilleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextVille.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextVilleProperty =
            DependencyProperty.Register("TextVille", typeof(string), typeof(ucAdmninistration), new PropertyMetadata("A renseigner"));
    }
}
