using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Admin
    {
        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // tout bon

        [InlineData("", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Non-renseigné", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // Prenom vide

        [InlineData("Bonneau", "", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Bonneau", "Non-renseigné", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // Nom vide

        [InlineData("Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // Email vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "Non-renseigné", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // telephone vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "", "Clermont-Ferrand", "63000", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "Non renseignée", "Clermont-Ferrand", "63000", "password", "NewPizza()")] // Adresse vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "", "63000", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Non-renseigné", "63000", "password", "NewPizza()")] // Ville vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "", "password", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "00000", "password", "NewPizza()")] // CodePostal vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "password", "")] // nomPizzeria vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "", "NewPizza()",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "1234", "NewPizza()")] // Mdp vide
        public void TEST_Ctor(string nom, string prénom, string email, string téléphone, string adresse, string ville, string codePostal, string mdp, string nomPizzeria,
                              string expNom, string expPrénom, string expEmail, string expTéléphone, string expAdresse, string expVille, string expCodePostal, string expMdp, string expNomPizzeria)
        {
            Administrateur adm = new Administrateur(nom, prénom, email, téléphone, adresse, ville, codePostal, mdp, nomPizzeria);
            Assert.Equal(expNom, adm.Nom);
            Assert.Equal(expPrénom, adm.Prénom);
            Assert.Equal(expTéléphone, adm.Téléphone);
            Assert.Equal(expAdresse, adm.Adresse);
            Assert.Equal(expVille, adm.Ville);
            Assert.Equal(expCodePostal, adm.CodePostal);
            Assert.Equal(expMdp, adm.Mdp);
            Assert.Equal(expNomPizzeria, adm.NomPizzeria);
            Assert.Equal(expEmail, adm.Email);

        }


        [Fact]
        public void TEST_ChangerStatusCommande()
        {
            Client c1 = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            Pizza p2 = new Pizza("Nom2", "Description2", "Image2", listIngre, 8);
            Administrateur admin = new Administrateur("Verdier", "Nathan", "nathan@newpizza.com", "06.45.85.95.00", "32 rue pizza", "Clermont-Ferrand", "63100", "password", "newPizza()");
            c1.ajouterPizzaCommande(p);
            Commande cmd = new Commande(c1, c1.ListPizzaClient);
            c1.envoyerListeCommande(cmd, admin);

            Status statcmd = cmd.Statut;

            admin.ChangerStatusCommande(cmd);

            if(statcmd == Status.Commencer)
            {
                Assert.Equal(Status.EnCours, cmd.Statut);
            }
            else if (statcmd == Status.EnCours)
            {
                Assert.Equal(Status.Finir, cmd.Statut);
            }
            else if (statcmd == Status.EnCours)
            {
                Assert.Null(cmd);
            }

        }

        [Fact]
        public void TEST_SuppCommande()
        {
            Client c1 = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            Pizza p2 = new Pizza("Nom2", "Description2", "Image2", listIngre, 8);
            Administrateur admin = new Administrateur("Verdier", "Nathan", "nathan@newpizza.com", "06.45.85.95.00", "32 rue pizza", "Clermont-Ferrand", "63100", "password", "newPizza()");
            c1.ajouterPizzaCommande(p);
            Commande cmd = new Commande(c1, c1.ListPizzaClient);
            c1.envoyerListeCommande(cmd, admin);

            Assert.NotEmpty(admin.ListCommandeAdmin);

            admin.SuppCommande(cmd);

            Assert.Empty(admin.ListCommandeAdmin);
        }

    }
}
