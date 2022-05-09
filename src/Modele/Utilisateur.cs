using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public abstract class Utilisateur
    {
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        private string nom;

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public string Prénom { get => prénom; set => prénom = value; }
        private string prénom;

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        public string Email { get => email; set => email = value; }
        private string email;

        /// <summary>
        /// Téléphone de l'utilisateur
        /// </summary>
        public string Téléphone { get => téléphone; set => téléphone = value; }
        private string téléphone;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Adresse { get => adresse; set => adresse = value; }
        private string adresse;

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string Ville { get => ville; set => ville = value; }
        private string ville;

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public string CodePostal { get => codePostal; set => codePostal = value; }
        private string codePostal;

        public Utilisateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prénom) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Un utilisateur doit avoir au moins un nom, un prénom et une adresse email");
            }
            Nom = nom;
            Prénom = prénom;
            Email = email;
            Téléphone = téléphone;
            Adresse = adresse;
            Ville = ville;
            CodePostal = codePostal;
        }
        /*
        public void EnregistrerModif()
        {

        }*/
        
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
        
        public bool Equals(Utilisateur other)
        {
            return (Nom == other.Nom && Prénom == other.Prénom) || Email==other.Email;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return false;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Utilisateur);
        }
        public override int GetHashCode()
        {
            if (!string.IsNullOrWhiteSpace(Nom)) return Nom.GetHashCode();
            if (!string.IsNullOrWhiteSpace(Prénom)) return Prénom.GetHashCode();
            return Email.GetHashCode();
        }
    }
}
