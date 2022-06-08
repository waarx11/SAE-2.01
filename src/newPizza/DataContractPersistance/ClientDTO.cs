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
    class ClientDTO
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string Nom { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string Prénom { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string Email { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string Téléphone { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string Adresse { get; set; } 
        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string Mdp { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 6)]
        public string Ville { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 7)]
        public string CodePostal { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 8)]
        public string Pseudo { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 9)]
        public string Photo { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 12)]
        public List<Pizza> ListCommandeClient { get; set; }
    }

    static class ClientExtensions
    {
        public static Client ToPOCOs(this ClientDTO dto)
            => new Client(dto.Nom, dto.Prénom, dto.Email, dto.Téléphone, dto.Adresse, dto.Ville, dto.CodePostal, dto.Mdp, dto.Pseudo, dto.Photo);

        public static IEnumerable<Client> ToPOCOs(this IEnumerable<ClientDTO> dtos)
            => dtos.Select(dto => dto.ToPOCOs());

        public static ClientDTO ToDTO(this Client poco)
            => new ClientDTO
            {
                Nom = poco.Nom,
                Prénom = poco.Prénom,
                Email = poco.Email,
                Téléphone = poco.Téléphone,
                Adresse = poco.Adresse,
                Mdp = poco.Mdp,
                Ville = poco.Ville,
                CodePostal = poco.CodePostal,
                Pseudo = poco.Pseudo,
                Photo = poco.Photo
            };

        public static IEnumerable<ClientDTO> ToDTOs(this IEnumerable<Client> pocos)
            => pocos.Select(dto => dto.ToDTO());
    }
}
