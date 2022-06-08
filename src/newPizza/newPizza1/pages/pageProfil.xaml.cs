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
using System.Windows.Shapes;
using Modele;
using newPizza1.converters;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageProfil.xaml
    /// </summary>
    public partial class pageProfil : Window
    {
        public Manager Mgr => ((App)App.Current).LeManager;
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
            MessageBoxResult result = MessageBox.Show("Déconnexion", "Voulez-vous vraiment vous  déconnecter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                pageIdentification identif = new pageIdentification();
                this.Close();
                identif.Show();
            }
        }


        public string Photo
        {
            get { return (string)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Photo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhotoProperty =
            DependencyProperty.Register("Photo", typeof(string), typeof(pageProfil), new PropertyMetadata("..\\img\\default\\noPP.jpg"));

        public void BTN_addImage(object sender, RoutedEventArgs e)
        {

            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif"; // Filter files by extension 

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                FileInfo fi = new FileInfo(dlg.FileName);
                string filename = fi.Name;
                int i = 0;
               /* mImage.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));*/


                while ( File.Exists(System.IO.Path.Combine(String2ImageConverter.ImagesPath, filename)))
                {
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf("."))}_{i}.{fi.Extension}";
                    i++;
                }
                File.Copy(dlg.FileName, System.IO.Path.Combine(String2ImageConverter.ImagesPath, filename));
                ((Client)Mgr.UtilisateurActuel).Photo = filename;
            }

        }

    }
}
