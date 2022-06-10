using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Permet de stocker les données
    /// </summary>
    public interface IPersistanceManager
    {
        (IEnumerable<Client> client, IEnumerable<Administrateur> admin, Catalogue catalogue) ChargeDonnées();
        void SauvegardeDonnées(IEnumerable<Client> client, IEnumerable<Administrateur> admin, Catalogue C1);
    }
}
