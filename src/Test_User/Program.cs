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

            /*listCommande.Add(pizza);

            listCommande.Remove(pizza);*/

        }
    }
}
