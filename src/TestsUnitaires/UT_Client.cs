using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Client
    {
        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // tout bon

        [InlineData("", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Non-renseigné", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Prenom vide

        [InlineData("Bonneau", "", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Non-renseigné", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Nom vide

        [InlineData("Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Email vide

        [InlineData("Bonneau", "Baptiste", "emailMarchePas", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Email sans @

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "Non-renseigné", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // telephone vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "Non-renseigné", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Adresse vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Non-renseigné", "63000", "default\noImg.png", false)] // Ville vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "00000", "default\noImg.png", false)] // CodePostal vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noPP.jpg", false)] // Image vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Pseudo vide

        public void TEST_Ctor(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo,
                              string expNom, string expPrénom, string expTéléphone, string expAdresse, string expVille, string expCodePostal, string expPhoto, bool shouldThrowException)
        {

            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, pseudo, photo));
                return;
            }
            
            Client c = new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, pseudo, photo);
            Assert.Equal(expNom, c.Nom);
            Assert.Equal(expPrénom, c.Prénom);
            Assert.Equal(expTéléphone, c.Téléphone);
            Assert.Equal(expAdresse, c.Adresse);
            Assert.Equal(expVille, c.Ville);
            Assert.Equal(expCodePostal, c.CodePostal);
            Assert.Equal(expPhoto, c.Photo);

        }

        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png")]
        public void TEST_ToString(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string pseudo, string photo)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Client c = new Client(nom, prénom, email, téléphone, adresse, ville, codePostal, pseudo, photo);
            string expectedAfficher = $"{nom} {prénom} {email} {téléphone} {adresse} {ville} {codePostal} {pseudo} {photo}";
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
    }
}
