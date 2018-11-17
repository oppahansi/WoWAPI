using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("spell_learn_spell")]
    public class SpellLearnSpellBase : IEntity
    {
        [Key]
        public ushort Entry { get; set; }
        [Key]
        public ushort SpellId { get; set; }
        public byte Active { get; set; }
    }
}
