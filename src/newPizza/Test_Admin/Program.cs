using Modele;
using System.Collections.Generic;
using System;

namespace Test_Admin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Administrateur");

            List<Ingredients> listeIngre1 = new List<Ingredients> { (Ingredients)2, (Ingredients)20 };
            List<Ingredients> listeIngre2 = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };

            Pizza P1 = new Pizza("Reine", "Description", "image", listeIngre1, 15);
            Pizza P2 = new Pizza("Peperonni", "Description", "image", listeIngre2, 10);

            Client C1 = new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "Mdp", "tobiii", "non");
            Administrateur admin = new Administrateur("Verdier", "Nathan", "nathan@newpizza.com", "06.45.85.95.00", "32 rue pizza", "Clermont-Ferrand", "63100", "password", "newPizza()");

            C1.ajouterPizzaCommande(P1);
            C1.ajouterPizzaCommande(P2);

            Commande c = new Commande(C1, C1.ListCommandeClient);
            C1.envoyerListeCommande(admin);



            Console.WriteLine("-----------------");
            Console.WriteLine("Statut de la commande");
            Console.WriteLine(c.Statut);
            Console.WriteLine("Changement du statut de la commande");
            admin.ChangerStatusCommande(c);
            Console.WriteLine(c.Statut);


            Console.WriteLine("-----------------");
            Console.WriteLine("Liste des commandes");
            foreach(Commande c1 in admin.ListCommandeAdmin)
            {
                    Console.WriteLine(c1);
            }
            Console.WriteLine("Suppresion d'une commande");
            admin.SuppCommande(c);
            foreach (Commande c1 in admin.ListCommandeAdmin)
            {
                Console.WriteLine(c1);
            }

        }
    }
}
