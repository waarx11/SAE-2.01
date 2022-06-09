using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /*[DataContract]*/
    public abstract class Utilisateur : IEquatable<Utilisateur> , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 0)]*/
        public string Nom
        {
            get => nom;
            set
            {
                if (Nom != value)
                {
                    nom = value;
                    OnPropertyChanged(nameof(Nom));
                }
            }
        }
        private string nom;

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 1)]*/
        public string Prénom
        {
            get => prénom;
            set
            {
                if (Prénom != value)
                {
                    prénom = value;
                    OnPropertyChanged(nameof(Prénom));
                }
            }
        }
        private string prénom;

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 2)]*/
        public string Email
        {
            get => email;
            set
            {
                if (Email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        private string email;

        /// <summary>
        /// Téléphone de l'utilisateur
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 3)]*/
        public string Téléphone
        {
            get => téléphone;
            set
            {
                if (Téléphone != value)
                {
                    téléphone = value;
                    OnPropertyChanged(nameof(Téléphone));
                }
            }
        }
        private string téléphone;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 4)]*/
        public string Adresse
        {
            get => adresse;
            set
            {
                if (Adresse != value)
                {
                    adresse = value;
                    OnPropertyChanged(nameof(Adresse));
                }
            }
        }
        private string adresse;

        /// <summary>
        /// Mot de passe de l'utilisateur pour ce connecter a l'application
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 5)]*/
        public string Mdp { get => mdp; private set => mdp = value; }
        private string mdp;
        /// <summary>
        /// Image de la pizza
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 6)]*/
        public string Ville
        {
            get => ville;
            set
            {
                if (Ville != value)
                {
                    ville = value;
                    OnPropertyChanged(nameof(Ville));
                }
            }
        }
        private string ville;

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        /*[DataMember(EmitDefaultValue = false, Order = 7)]*/
        public string CodePostal
        {
            get => codePostal;
            set
            {
                if (CodePostal != value)
                {
                    codePostal = value;
                    OnPropertyChanged(nameof(CodePostal));
                }
            }
        }
        private string codePostal;


        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        public Utilisateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp)
        {

            Email = email;
            if (string.IsNullOrWhiteSpace(nom))
            {
                Nom = "Non-renseigné";
            }
            else
            {
                Nom = nom;
            }

            if (string.IsNullOrWhiteSpace(prénom))
            {
                Prénom = "Non-renseigné";
            }
            else
            {
                Prénom = prénom;
            }

            if (string.IsNullOrWhiteSpace(codePostal))
            {
                CodePostal = "00000";
            }
            else {
                CodePostal = codePostal;
            }

            if (string.IsNullOrWhiteSpace(téléphone))
            {
                Téléphone = "Non-renseigné";
            }
            else
            {
                Téléphone = téléphone;
            }

            if (string.IsNullOrWhiteSpace(adresse))
            {
                Adresse = "Non renseignée";
            }
            else
            {
                Adresse = adresse;
            }

            if (string.IsNullOrWhiteSpace(ville))
            {
                Ville = "Non-renseigné";
            }
            else
            {
                Ville = ville;
            }

            if (string.IsNullOrWhiteSpace(mdp))
            {
                Mdp = "1234";
            }
            else
            {
                Mdp = mdp;
            }
        }
    /// <summary>
    /// Permet de changer divers information d'un utilisateur
    /// </summary>
    /// <param name="nom"></param>
    /// <param name="prénom"></param>
    /// <param name="email"></param>
    /// <param name="téléphone"></param>
    /// <param name="adresse"></param>
    /// <param name="ville"></param>
    /// <param name="codePostal"></param>
    public Utilisateur EnregistrerModif(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
    {
        Nom = nom;
        Prénom = prénom;
        Email = email;
        Téléphone = téléphone;
        Adresse = adresse;
        Ville = ville;
        CodePostal = codePostal;
        return this;
    }
    /// <summary>
    /// Permet de changer le mot de passe d'un utilisateur
    /// </summary>
    /// <param name="mdp"></param>
    public void ModifierMdp(string mdp)
    {
        Mdp = mdp;
    }

    public override string ToString()
        {
            string nom = string.IsNullOrWhiteSpace(Nom) ? "" : $"{Nom}";
            string prénom = string.IsNullOrWhiteSpace(Prénom) ? "" : $"{Prénom}";
            string email = string.IsNullOrWhiteSpace(Email) ? "" : $"{Email}";
            string téléphone = string.IsNullOrWhiteSpace(Téléphone) ? "" : $"{Téléphone}";
            string adresse = string.IsNullOrWhiteSpace(Adresse) ? "" : $"{Adresse}";
            string ville = string.IsNullOrWhiteSpace(Ville) ? "" : $"{Ville}";
            string codePostal = string.IsNullOrWhiteSpace(CodePostal) ? "" : $"{CodePostal}";
            return $"{nom} {prénom} {email} {téléphone} {adresse} {ville} {codePostal}";
        }
        
        /// <summary>
        /// Fonction qui permet de vérifier que l'utilisateur existe déjà ou non
        /// </summary>
        /// <param name="other"></param>
        /// <returns>
        /// True si la personne existe déjà false sinon
        /// </returns>
        public bool Equals(Utilisateur other)
        {
            return (Nom == other.Nom && Prénom == other.Prénom) || Email==other.Email;
        }
        /// <summary>
        /// Regarde l'existatn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// False si obj est null, si il est égale est égale a lui même ou si il n'a pas le bon type sinon return le resultat de la fonction Equals(Utilisateur other)
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return false;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Utilisateur);
        }
        /// <summary>
        /// Fonction de hashage
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (!string.IsNullOrWhiteSpace(Nom)) return Nom.GetHashCode();
            if (!string.IsNullOrWhiteSpace(Prénom)) return Prénom.GetHashCode();
            return Email.GetHashCode();
        }
    }
}
