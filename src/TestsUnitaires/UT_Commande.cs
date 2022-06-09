using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Commande
    {
        
        [Fact]
        public void TEST_Ctor()
        {
            Client c = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            c.ajouterPizzaCommande(p);

            Commande cmd = new Commande(c, c.ListPizzaClient);

            Assert.Equal(cmd.ClientActu, c);
            Assert.Equal(cmd.ListPizza, c.ListPizzaClient);
            Assert.Equal(Status.Commencer, cmd.Statut);

        }

        [Fact]
        public void TEST_ChangerStatut()
        {
            Client c = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            c.ajouterPizzaCommande(p);

            Commande cmd = new Commande(c, c.ListPizzaClient);

            Status lastStatus = cmd.Statut;

            cmd.changerStatus();
            if(lastStatus == Status.Commencer)
            {
                Assert.Equal(Status.EnCours, cmd.Statut);
            }
            else if (lastStatus == Status.EnCours)
            {
                Assert.Equal(Status.Finir, cmd.Statut);
            }
            else if (lastStatus == Status.Finir)
            {
                Assert.Null(cmd);
            }

        }

        [Fact]
        public void TEST_ToString()
        {
            Client c = new Client("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0606060606", "37 rue mon adresse", "clermont", "password", "pseudo", "photo.png");
            List<Ingredients> listIngre = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
            Pizza p = new Pizza("Nom", "Description", "Image", listIngre, 8);
            c.ajouterPizzaCommande(p);

            Commande cmd = new Commande(c, c.ListPizzaClient);

            string expectedTexte = $"{cmd.ClientActu.Pseudo}, ";
            foreach(Pizza pizz in cmd.ListPizza)
            {
                expectedTexte += $"{pizz}, ";
            }
            expectedTexte += $"{cmd.Statut}";
        }

    }
}
