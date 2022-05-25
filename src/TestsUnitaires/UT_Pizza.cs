using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Pizza
    {
        [Theory]
        [InlineData("Nom1", "Description1", "Image1", 15, "Nom1", "Description1", "Image1", 15)] // Tout bon
        [InlineData("Nom2", "Description2", "Image2", -1, "Nom2", "Description2", "Image2", 12)] // Prix négatif
        [InlineData("Nom3", "Description3", "Image3", 0, "Nom3", "Description3", "Image3", 12)] // Prix = 0
        [InlineData("", "Description4", "Image4", 15, "Aucun Nom", "Description4", "Image4", 15)] // Nom vide
        [InlineData("Nom5", "", "Image5", 15, "Nom5", "Aucune Description", "Image5", 15)] // Description vide
        [InlineData("Nom6", "Description6", "", 15, "Nom6", "Description6", "default\noImg.png", 15)] // Image vide
        public void TEST_Ctor(string nom, string description, string image, int prix, 
                              string expectNom, string expectDesc, string expectImage, int expectPrix)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Pizza p = new Pizza(nom, description, image, liste, prix);
            Assert.Equal(expectNom, p.Nom);
            Assert.Equal(expectDesc, p.Description);
            Assert.Equal(expectImage, p.Image);
            Assert.Equal(expectPrix, p.Prix);
            Assert.Equal(liste, p.listIngredient);
        }


        [Theory]
        [InlineData(1)] // tout bon
        [InlineData(0)] // valeur nulle
        [InlineData(-1)] // valeur négative
        public void TEST_modifQte(int valeur)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Pizza p = new Pizza("Salmone", "Une pizza au saumon d'origine normande", "default\noImg.png", liste, 13);
            p.modifQte(valeur);
            /*Assert.Equal(p.Quantité+valeur, p.Quantité);*/
            Assert.DoesNotContain("-", p.Quantité.ToString());
        }

        [Theory]
        [InlineData("Nom1", "Description1", "Image1", 15, 1, "Nom1", "Description1", "Image1", 15)] // Tout bon
        [InlineData("Nom2", "Description2", "Image2", -1, 2, "Nom2", "Description2", "Image2", 12)] // Prix négatif
        [InlineData("Nom3", "Description3", "Image3", 0, 7, "Nom3", "Description3", "Image3", 12)] // Prix = 0
        [InlineData("", "Description4", "Image4", 15, 1, "Aucun Nom", "Description4", "Image4", 15)] // Nom vide
        [InlineData("Nom5", "", "Image5", 15, 0, "Nom5", "Aucune Description", "Image5", 15)] // Description vide
        [InlineData("Nom6", "Description6", "", 15, 1, "Nom6", "Description6", "default\noImg.png", 15)] // Image vide
        public void TEST_ToString(string nom, string description, string image, int prix, int quantité,
                               string expectNom, string expectDesc, string expectImage, int expectPrix)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Pizza p = new Pizza(nom, description, image, liste, prix);
            //p.Quantité = quantité;
            string expectedAfficher = $"{expectNom} {expectDesc} {expectImage} ";
            foreach (Ingredients element in liste)
            {
                expectedAfficher += $"{element} ";
            }
            expectedAfficher += $"{expectPrix} {p.Quantité} ";

            Assert.Equal(expectedAfficher, p.ToString());

            /*Console.WriteLine(expectedAfficher);
            Console.WriteLine(p.ToString());*/

        }

       

        [Theory]
        [InlineData("Pareil", "Pareil", true)] // tout bon
        [InlineData("pasPareil", "Pareil", false)] // 1 pas bon
        [InlineData("Pareil", "pasPareil", false)] // 2 pas bon

        public void TEST_Equals(string nom1, string nom2, bool expectResult)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Pizza p1 = new Pizza(nom1, "Description", "Image", liste, 10);
            Pizza p2 = new Pizza(nom2, "Description", "Image", liste, 10);
            bool result = p1.Equals(p2);
            Assert.Equal(expectResult, result);

        }

    }
}
