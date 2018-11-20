using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TSkinningLootTemplate : SkinningLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
