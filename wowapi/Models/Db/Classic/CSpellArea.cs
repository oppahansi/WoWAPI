using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_area")]
    public class CSpellArea : SpellAreaBase
    {
        [Key]
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
