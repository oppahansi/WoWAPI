using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_affect")]
    public class CSpellAffect
    {
        [Key]
        public ushort Entry { get; set; }
        [Key]
        public byte EffectId { get; set; }
        public ulong SpellFamilyMask { get; set; }
    }
}
