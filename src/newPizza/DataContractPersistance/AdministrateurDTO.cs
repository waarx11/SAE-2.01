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
    class AdministrateurDTO
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
        public string NomPizzeria { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 9)]
        public List<Commande> ListCommandeAdmin { get; set; }
    }

    static class AdministrateurExtensions
    {
        public static Administrateur ToPOCOs(this AdministrateurDTO dto)
            => new Administrateur(dto.Nom, dto.Prénom, dto.Email, dto.Téléphone, dto.Adresse, dto.Mdp, dto.Ville, dto.CodePostal, dto.NomPizzeria);

        public static IEnumerable<Administrateur> ToPOCOs(this IEnumerable<AdministrateurDTO> dtos)
            => dtos.Select(dto => dto.ToPOCOs());

        public static AdministrateurDTO ToDTO(this Administrateur poco)
            => new AdministrateurDTO
            {
                Nom = poco.Nom,
                Prénom = poco.Prénom,
                Email = poco.Email,
                Téléphone = poco.Téléphone,
                Adresse = poco.Adresse,
                Mdp = poco.Mdp,
                Ville = poco.Ville,
                CodePostal = poco.CodePostal,
                NomPizzeria = poco.NomPizzeria
            };

        public static IEnumerable<AdministrateurDTO> ToDTOs(this IEnumerable<Administrateur> pocos)
            => pocos.Select(dto => dto.ToDTO());
    }
}
