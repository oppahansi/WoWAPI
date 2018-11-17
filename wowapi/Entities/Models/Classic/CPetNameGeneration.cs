using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("pet_name_generation")]
    public class CPetNameGeneration : PetNameGenerationBase
    {
        public sbyte Half { get; set; }
    }
}
