using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("spell_pet_auras")]
    public class SpellPetAurasBase : IEntity
    {
        [Key]
        public uint Spell { get; set; }
        [Key]
        public uint Pet { get; set; }
        public uint Aura { get; set; }
    }
}
