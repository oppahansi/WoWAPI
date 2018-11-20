using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("disenchant_loot_template")]
    public class CDisenchantLootTemplate : DisenchantLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
