using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette class permet de crée un client et elle hérite de la class utilisateur
    /// </summary>
    /*[DataContract]*/
    public class Client : Utilisateur, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 8)]*/
        public string Pseudo { get => pseudo; private set => pseudo = value; }
        private string pseudo;
        /// <summary>
        /// Photo de l'utilisateur
        /// </summary>
        private string photo;
        /*[DataMember(EmitDefaultValue = false, Order = 9)]*/
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
        private List<Pizza> listPizzaClient;
        /*[DataMember(EmitDefaultValue = false, Order = 10)]*/
        public List<Pizza> ListPizzaClient { get => listPizzaClient; private set => listPizzaClient = value; }

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
            ListPizzaClient = new List<Pizza>();
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
        public void envoyerListeCommande(Commande c, Administrateur admin)
        {
            admin.ListCommandeAdmin.Add(c);
            ListPizzaClient.Clear();
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


            else if (!ListPizzaClient.Contains(p))
            {
                ListPizzaClient.Add(p);
                return true;
            }
            else if (ListPizzaClient.Contains(p))
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
            if (ListPizzaClient.Contains(p))
            {
                ListPizzaClient.Remove(p);
                return true;
            }
            return false;
        }

    }
}
