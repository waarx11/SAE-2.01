using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public abstract class Utilisateur : IEquatable<Utilisateur>
    {
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string Nom { get => nom; private set => nom = value; }
        private string nom;

        /// <summary>
        /// Quantité de pizza a commander
        /// </summary>
        public string Prénom { get => prénom; private set => prénom = value; }
        private string prénom;

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        public string Email { get => email; private set => email = value; }
        private string email;

        /// <summary>
        /// Téléphone de l'utilisateur
        /// </summary>
        public string Téléphone { get => téléphone; private set => téléphone = value; }
        private string téléphone;

        /// <summary>
        /// Description de la pizza
        /// </summary>
        public string Adresse { get => adresse; private set => adresse = value; }
        private string adresse;

        /// <summary>
        /// Image de la pizza
        /// </summary>
        public string Ville { get => ville; private set => ville = value; }
        private string ville;

        /// <summary>
        /// Prix de la pizza
        /// </summary>
        public string CodePostal { get => codePostal; private set => codePostal = value; }
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
        public Utilisateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
        {

            if (!email.Contains("@") || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Adresse email invalide");
            }
            else
            {
                Email = email;
            }

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
                Adresse = "Non-renseigné";
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

        }
        
        public void EnregistrerModif(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
        {
            Nom = nom;
            Prénom = prénom;
            Email = email;
            Téléphone = téléphone;
            Adresse = adresse;
            Ville = ville;
            CodePostal = codePostal;
        }
    /// <summary>
    /// 
    /// </summary>
    /// <returns>
    /// return le nom, prénom, email, téléphone, adresse, ville et code postal d'un utilisateur
    /// </returns>
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

        public override int GetHashCode()
        {
            if (!string.IsNullOrWhiteSpace(Nom)) return Nom.GetHashCode();
            if (!string.IsNullOrWhiteSpace(Prénom)) return Prénom.GetHashCode();
            return Email.GetHashCode();
        }
    }
}
