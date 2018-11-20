using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("spell_pet_auras")]
    public class SpellPetAurasBase
    {
        [Key]
        public uint Spell { get; set; }
        [Key]
        public uint Pet { get; set; }
        public uint Aura { get; set; }
    }
}
