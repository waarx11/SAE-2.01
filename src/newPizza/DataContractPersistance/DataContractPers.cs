using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "XML");
        public string FileName { get; set; } = "newPizzaPers";
        string PersFile => Path.Combine(FilePath, FileName);
        internal List<Client> LesClients { get; set; } = new List<Client>();
        internal List<Administrateur> LesAdmin { get; set; } = new List<Administrateur>();
        internal Catalogue LeCatalogue { get; set; } = new Catalogue();
        private DataContractSerializer Serializer { get; set; } = new DataContractSerializer(typeof(DataToPersist),
                                                    new DataContractSerializerSettings()
                                                    {
                                                        PreserveObjectReferences = true
                                                    });
        public (IEnumerable<Client> client, IEnumerable<Administrateur> admin, Catalogue catalogue) ChargeDonnées()
        {
            if(!File.Exists(PersFile))
            {
                throw new FileNotFoundException("The persistance file is missing");
            }

            DataToPersist? data;
            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }
            LesClients = data.Clients.ToPOCOs().ToList();
            LesAdmin = data.Admin.ToPOCOs().ToList();
            LeCatalogue = data.Catalogues;
            Debug.WriteLine(LesClients.Last());
            return (LesClients, LesAdmin, data.Catalogues);

        }

        public void SauvegardeDonnées(IEnumerable<Client> client, IEnumerable<Administrateur> admin, Catalogue C1)
        {
            
            if(!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Clients.AddRange(client.ToDTOs());
            data.Admin.AddRange(admin.ToDTOs());
            data.Catalogues = C1;

            var settings = new XmlWriterSettings() { Indent = true };
            using (TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    Serializer.WriteObject(writer, data);
                }
            }
        }
    }
}