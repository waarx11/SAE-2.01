using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Client
    {
        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // tout bon

        [InlineData("", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Non-renseigné", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // Prenom vide

        [InlineData("Bonneau", "", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Non-renseigné", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // Nom vide

        [InlineData("Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // Email vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "Non-renseigné", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // telephone vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "Non renseignée", "Clermont-Ferrand", "63000", "password", "Bapt", "default\noImg.png")] // Adresse vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "", "63000", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Non-renseigné", "63000", "password", "Bapt", "default\noImg.png")] // Ville vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "", "password", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "00000", "password", "Bapt", "default\noImg.png")] // CodePostal vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "Bapt", "..\\img\\default\\noPP.jpg")] // Image vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "", "default\noImg.png")] // Pseudo vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "1234", "Bapt", "default\noImg.png")] // Mdp vide

        public void TEST_Ctor(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string pseudo, string photo,
                              string expNom, string expPrénom, string expEmail, string expTéléphone, string expAdresse, string expVille, string expCodePostal, string expMdp, string expPseudo, string expPhoto)
        {
            Client c = new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, pseudo, photo);
            Assert.Equal(expNom, c.Nom);
            Assert.Equal(expPrénom, c.Prénom);
            Assert.Equal(expTéléphone, c.Téléphone);
            Assert.Equal(expAdresse, c.Adresse);
            Assert.Equal(expVille, c.Ville);
            Assert.Equal(expCodePostal, c.CodePostal);
            Assert.Equal(expPhoto, c.Photo);
            Assert.Equal(expMdp, c.Mdp);
            Assert.Equal(expPseudo, c.Pseudo);
            Assert.Equal(expEmail, c.Email);
        }


        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png")]
        public void TEST_ToString(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Client c = new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, pseudo, photo);
            string expectedAfficher = $"{c.Nom} {c.Prénom} {c.Email} {c.Téléphone} {c.Adresse} {c.Ville} {c.CodePostal} {c.Pseudo} {c.Photo}";
            Assert.Equal(expectedAfficher, c.ToString());
        }


        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png", true)] // pareil

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "00000", "Lolo", "default\noImg.png", false)] // pas pareil

        [InlineData("Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "00000", "Lolo", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png", false)] // pas pareil
        public void TEST_Equals(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo,
                                string nom2, string prénom2, string email2, string téléphone2, string adresse2, string ville2, string codePostal2, string pseudo2, string photo2, bool expectResult)
        {
            Client c1 = new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, pseudo, photo);
            Client c2 = new Client(nom2, prénom2, email2, téléphone2, adresse2, ville2, codePostal2, pseudo2, photo2);
            bool result = c1.Equals(c2);
            Assert.Equal(expectResult, result);

        }

        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000")]
        [InlineData("Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "63000")]
        public void TEST_EnregistrerModif(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal)
        {
            Client c1 = new Client("Nom", "Prénom", "nathan.verdier@etu.uca.fr", "0676260411", "Adresse", "Ville", "63000", "Pseudo", "default\noPP.jpg");
            c1.EnregistrerModif(nom, prénom, email, téléphone, adresse, ville, codePostal);
            Assert.Equal(nom, c1.Nom);
            Assert.Equal(prénom, c1.Prénom);
            Assert.Equal(email, c1.Email);
            Assert.Equal(téléphone, c1.Téléphone);
            Assert.Equal(adresse, c1.Adresse);
            Assert.Equal(ville, c1.Ville);
            Assert.Equal(codePostal, c1.CodePostal);
        }


        [Fact]
        public void TEST_EnvoyerListeCommande()
        {
            Client c1 = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            Pizza p2 = new Pizza("Nom2", "Description2", "Image2", listIngre, 8);
            Administrateur admin = new Administrateur("Verdier", "Nathan", "nathan@newpizza.com", "06.45.85.95.00", "32 rue pizza", "Clermont-Ferrand", "63100", "password", "newPizza()");
            c1.ajouterPizzaCommande(p);
            Commande cmd = new Commande(c1, c1.ListPizzaClient);
            c1.envoyerListeCommande(cmd, admin);

            Assert.Single(admin.ListCommandeAdmin);

            Client c2 = new Client("Nathan", "Verdier", "nathan.verdier@etu.uca.fr", "0000000011", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            c2.ajouterPizzaCommande(p);
            c2.ajouterPizzaCommande(p);
            Commande cmd2 = new Commande(c2, c2.ListPizzaClient);
            c2.envoyerListeCommande(cmd2, admin);
            Assert.Equal(2, admin.ListCommandeAdmin.Count);

        }

        [Fact]
        public void TEST_AjouterPizzaCommande()
        {
            Client c1 = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            c1.ajouterPizzaCommande(p);
            Assert.Contains(p, c1.ListPizzaClient);
        }

        [Fact]
        public void TEST_SupprimerPizzaCommande()
        {
            Client c1 = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            c1.ajouterPizzaCommande(p);
            Assert.Contains(p, c1.ListPizzaClient);
            c1.supprimerPizzaCommande(p);
            Assert.DoesNotContain(p, c1.ListPizzaClient);
        }
    }
}
