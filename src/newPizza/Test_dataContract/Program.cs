using System;
using System.Collections.Generic;
using Modele;

namespace Test_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Stub.Stub());
            manager.ChargeDonnées();
            manager.Persistance = new DataContractPersistance.DataContractPers();
            manager.SauvegardeDonnées();

            /*Manager manager2 = new Manager(new DataContractPersistance.DataContractPers());
            manager2.ChargeDonne();*/
        }
    }
}
