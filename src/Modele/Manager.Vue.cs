using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public partial class Manager
    {
        /// <summary>
        /// Cette vriable permet de connaitre l'utilisateur actuelle
        /// </summary>
        public Utilisateur UtilisateurActuel
        {
            get => utilisateurActuel;
            set
            {
                if (UtilisateurActuel != value)
                {
                    utilisateurActuel = value;
                    OnPropertyChanged(nameof(UtilisateurActuel));
                }
            }
        }
        private Utilisateur utilisateurActuel;



        public Pizza PizzaActuelle
        {
            get => pizzaActuelle;
            set
            {
                if (PizzaActuelle != value)
                {
                    pizzaActuelle = value;
                    OnPropertyChanged(nameof(PizzaActuelle));
                }
            }
        }
        private Pizza pizzaActuelle;



        public Commande CommandeActuelle
        {
            get => commandeActuelle;
            set
            {
                if (CommandeActuelle != value)
                {
                    commandeActuelle = value;
                    OnPropertyChanged(nameof(CommandeActuelle));
                }
            }
        }
        private Commande commandeActuelle;

    }

}
