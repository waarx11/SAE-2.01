using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette class permet de crée un client et elle hérite de la class utilisateur
    /// </summary>
    public class Client : Utilisateur, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged2;
        void OnPropertyChanged(string propertyName)
            => PropertyChanged2?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        public string Pseudo { get => pseudo; private set => pseudo = value; }
        private string pseudo;
        /// <summary>
        /// Photo de l'utilisateur
        /// </summary>
        private string photo;
        public string Photo { get => photo; 
            set
            {
                if (Photo != value)
                {
                    
                    photo = value;
                    OnPropertyChanged(nameof(Photo));
                }
            }
                }


        /// <summary>
        /// Liste des commandes du client
        /// </summary>
        private List<Pizza> listCommandeClient;
        public List<Pizza> ListCommandeClient { get => listCommandeClient; private set => listCommandeClient = value; }

        /// <summary>
        /// Constructeur de la classe Client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="pseudo"></param>
        /// <param name="photo"></param>
        public Client(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string pseudo, string photo=null)
            :base(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp)
        {
            Pseudo = pseudo;
            if (string.IsNullOrWhiteSpace(photo))
            {
                Photo = "..\\img\\default\\noPP.jpg";
            }
            else
            {
                Photo = photo;
            }
            listCommandeClient=new List<Pizza>();
        }

        /// <summary>
        /// Constructeur de la classe Client
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pseudo"></param>
        /// <param name="mdp"></param>
        public Client(string email, string pseudo, string mdp)
            : this("", "", email, "", "", "", "", mdp, pseudo, "")            
        { }

        public override string ToString()
        {
            return $"{base.ToString()} {Pseudo} {Photo}";
        }

        /// <summary>
        /// Envoie la liste de commande du client à l'administrateur et la vide une fois fait
        /// </summary>
        /// <param name="admin"></param>
        public void envoyerListeCommande(Administrateur admin)
        {
            Commande commande = new Commande(this, listCommandeClient);
            admin.ListCommandeAdmin.Add(commande);
            listCommandeClient.Clear();
        }

        /// <summary>
        /// Ajoute une pizza a la liste des commande du client
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool ajouterPizzaCommande(Pizza p)
        {
            if(p== null)
                return false;

            if (!listCommandeClient.Contains(p))
            {
                listCommandeClient.Add(p);
                return true;
            }

            if (listCommandeClient.Contains(p))
            {
                p.modifQte(1);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Supprime une pizza de la liste des commande du client
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool supprimerPizzaCommande(Pizza p)
        {
            if (listCommandeClient.Contains(p))
            {
                listCommandeClient.Remove(p);
                return true;
            }
            return false;
        }

    }
}
