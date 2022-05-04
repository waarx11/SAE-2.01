using System;
using Modele;

namespace Test_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Pizzza");

            Pizza P1 = new Pizza("Reine", "Bonne", "oui", 15);
            Pizza P2 = new Pizza("tkt", "non", "oui", 102);
            Pizza P3 = new Pizza("Saucisse", "gourmande", "non");
            Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3);
        }
    }
}
