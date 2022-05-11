using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Administrateur : Utilisateur
    {
        /// <summary>
        /// nom de la pizzeria 
        /// </summary>
        private string nomPizzeria;
        public string NomPizzeria { get => nomPizzeria; set => nomPizzeria = value; }
        /// <summary>
        /// Construteur de la classe Administrateur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prénom"></param>
        /// <param name="email"></param>
        /// <param name="téléphone"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        /// <param name="nomPizzeria"></param>
        public Administrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string nomPizzeria)
           : base(nom, prénom, email, téléphone, adresse, ville, codePostal)
        {
            NomPizzeria = nomPizzeria;
        }
    }
}
