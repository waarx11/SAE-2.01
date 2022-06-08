using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataContractPersistance
{
    [DataContract]
    class DataToPersist
    {
        [DataMember]
        public List<ClientDTO> Clients { get; set; } = new List<ClientDTO>();
        [DataMember]
        public List<AdministrateurDTO> Admin { get; set; } = new List<AdministrateurDTO>();
        [DataMember]
        public Catalogue Catalogues { get; set; } = new Catalogue();
    }
}
