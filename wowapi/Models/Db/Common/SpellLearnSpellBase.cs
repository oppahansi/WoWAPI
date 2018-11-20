using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("spell_learn_spell")]
    public class SpellLearnSpellBase
    {
        [Key]
        public ushort Entry { get; set; }
        [Key]
        public ushort SpellId { get; set; }
        public byte Active { get; set; }
    }
}
