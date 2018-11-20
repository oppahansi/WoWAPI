using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("pet_name_generation")]
    public class CPetNameGeneration : PetNameGenerationBase
    {
        public sbyte Half { get; set; }
    }
}
