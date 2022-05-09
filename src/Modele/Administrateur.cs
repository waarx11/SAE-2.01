using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Administrateur : Utilisateur
    {
        private string nomPizzeria;
        public string NomPizzeria { get => nomPizzeria; set => nomPizzeria = value; }
        public Administrateur(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string nomPizzeria)
           : base(nom, prénom, email, téléphone, adresse, ville, codePostal)
        {
            NomPizzeria = nomPizzeria;
        }
    }
}
