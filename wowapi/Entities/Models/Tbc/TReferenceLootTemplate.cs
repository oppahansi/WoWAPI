using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TReferenceLootTemplate : ReferenceLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
