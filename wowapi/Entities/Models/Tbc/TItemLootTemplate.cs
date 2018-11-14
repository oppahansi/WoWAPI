using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TItemLootTemplate : ItemLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public ushort Maxcount { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
