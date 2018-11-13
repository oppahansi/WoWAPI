using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TSpellArea : SpellAreaBase
    {
        public byte QuestStartActive { get; set; }
        public uint ConditionId { get; set; }
    }
}
