using System;
using Modele;

namespace Test_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User client");
            Client C1 = new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "tobiii", "non");
            Console.WriteLine(C1);
            C1.EnregistrerModif("aze", "ertre", "emre@non.com", "06.12.85.95.15", "42 rue oui", "Ferrand", "63100", "dddddd", "je sais pas");
            Console.WriteLine(C1);

            Console.WriteLine("Pizzeria");
            Administrateur A1 = new Administrateur("Bonneau", "Baptiste", "Baptiste@oui.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand", "63000", "nojii");
            Console.WriteLine(A1);
            A1.EnregistrerModif("Bonneau", "Baptiste", "Baptiste@non.com", "09.25.25.73.19", "27 rue non", "Clermont-Ferrand", "63000", "newPizza1()");
            Console.WriteLine(A1); 

            /*listCommande.Add(pizza);

            listCommande.Remove(pizza);*/

        }
    }
}
