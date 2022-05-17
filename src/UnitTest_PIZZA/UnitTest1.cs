using System;
using Modele;
using Xunit;

namespace UnitTest
{
    public class UnitTestPizza
    {
        [Theory]
        [InlineData("")]
        [InlineData()]
        [InlineData()]
        public void Test_Construtor(string nom, string description, string image, List<Ingredients> lIng, int prix = 12)
        {
            Pizza p = new Pizza(nom, description, image, lIng);
        }
    }
}
