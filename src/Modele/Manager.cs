using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;



namespace Modele
{
    public class Manager /*: INotifyPropertyChanged*/
    {
        public ReadOnlyCollection<Client> Clients { get; private set; }
        List<Client> clients = new List<Client> ();
        public ReadOnlyCollection<Administrateur> Administrateurs { get; private set; }
        List<Administrateur> administrateurs = new List<Administrateur>();

        public bool AjouteClient(Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (clients.Contains(client))
            {
                return false;
            }
            clients.Add(client);
            return true;
        }

        public bool AjouteAdministrateur(Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (clients.Contains(client))
            {
                return false;
            }
            clients.Add(client);
            return true;
        }
        public Manager(/*IPersistanceManager p*/)
        {
            //Persist = p;
            Administrateurs = new ReadOnlyCollection<Administrateur>(administrateurs);
            Clients = new ReadOnlyCollection<Client>(clients);
        }


    }
}
