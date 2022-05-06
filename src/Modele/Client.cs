using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Client : Utilisateur
    {
        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        private string Pseudo;
        public string pseudo { get => Pseudo; set => Pseudo = value; }
        /// <summary>
        /// Photo de l'utilisateur
        /// </summary>
        private string Photo;

        public Client(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo=null)
            :base(nom, prénom, email, téléphone, adresse, ville, codePostal)
        {
            Pseudo = pseudo;
            Photo = photo;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Pseudo} {Photo}";
        }
    }
}
