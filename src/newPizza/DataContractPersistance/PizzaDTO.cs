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
    class PizzaDTO
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string Nom { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public int Quantité { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string Description { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string ImageName { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public int Prix { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 4)]
        public List<Ingredients> listIngredient { get; set; }
    }

    static class PizzaExtensions
    {
        public static Pizza ToPOCOs(this PizzaDTO dto)
            => new Pizza(dto.Nom, dto.Description, dto.ImageName, dto.listIngredient, dto.Prix);

        public static IEnumerable<Pizza> ToPOCOs(this IEnumerable<PizzaDTO> dtos)
            => dtos.Select(dto => dto.ToPOCOs());

        public static PizzaDTO ToDTO(this Pizza poco)
            => new PizzaDTO
            {
                Nom = poco.Nom,
                Description = poco.Description,
                ImageName = poco.ImageName,
                listIngredient = poco.listIngredient,
                Prix = poco.Prix
            };

        public static IEnumerable<PizzaDTO> ToDTOs(this IEnumerable<Pizza> pocos)
            => pocos.Select(dto => dto.ToDTO());
    }
}
