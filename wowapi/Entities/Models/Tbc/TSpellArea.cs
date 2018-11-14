using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TSpellArea : SpellAreaBase
    {
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
