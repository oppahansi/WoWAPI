using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("reference_loot_template")]
    public class CReferenceLootTemplate : ReferenceLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        [Column("condition_id")]
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
