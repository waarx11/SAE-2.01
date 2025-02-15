﻿using System;
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
    /// Logique d'interaction pour ucTopBar.xaml
    /// </summary>
    public partial class ucTopBar : UserControl
    {
        public ucTopBar()
        {
            InitializeComponent();
        }

        public string setTitle
        {
            set
            {
                Title.Text = value;
            }
        }

        public void MonPanier(object sender, RoutedEventArgs e)
        {
            var window = new pageMonPanier();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
            window.Show();
        }
        public void MonCompte(object sender, RoutedEventArgs e)
        {
            var window = new pageProfil();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
            window.Show();
        }
    }
}
