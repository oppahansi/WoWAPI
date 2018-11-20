using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("gameobject_loog_template")]
    public class CGameObjectLootTemplate : GameObjectLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
