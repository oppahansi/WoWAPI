using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("pet_name_generation")]
    public class CPetNameGeneration : PetNameGenerationBase
    {
        public sbyte Half { get; set; }
    }
}
