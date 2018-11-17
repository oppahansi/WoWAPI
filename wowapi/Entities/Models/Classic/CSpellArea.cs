using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("spell_area")]
    public class CSpellArea : SpellAreaBase
    {
        [Key]
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
