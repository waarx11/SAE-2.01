using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    abstract class Utilisateur
    {
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public string Prénom { get; private set; }

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Téléphone de l'utilisateur
        /// </summary>
        public string Téléphone { get; private set; }

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Adresse { get; private set; }

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string Ville { get; private set; }

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public string CodePostal { get; private set; }

        Utilisateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prénom) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Un utilisateur doit avoir au moins un nom, un prénom et une adresse email");
            }
            Nom = Nom;
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
            string nom = string.IsNullOrWhiteSpace(Nom) ? "" : $"\"{Nom}\"";
            string prénom = string.IsNullOrWhiteSpace(Prénom) ? "" : $"\"{Prénom}\"";
            string email = string.IsNullOrWhiteSpace(Email) ? "" : $"\"{Email}\"";
            string téléphone = string.IsNullOrWhiteSpace(Téléphone) ? "" : $"\"{Téléphone}\"";
            string adresse = string.IsNullOrWhiteSpace(Adresse) ? "" : $"\"{Adresse}\"";
            string ville = string.IsNullOrWhiteSpace(Ville) ? "" : $"\"{Ville}\"";
            string codePostal = string.IsNullOrWhiteSpace(CodePostal) ? "" : $"\"{CodePostal}\"";
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
