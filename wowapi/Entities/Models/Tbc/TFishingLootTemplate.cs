using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TFishingLootTemplate : FishingLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
