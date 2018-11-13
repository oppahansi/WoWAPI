using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("spell_area")]
    public class CSpellArea : SpellAreaBase
    {
        [Key]
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
