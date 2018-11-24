using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_loot_template")]
    public class CCreatureLootTemplate : CreatureLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        [Column("condition_id")]
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
