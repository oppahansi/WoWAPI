using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
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
