using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("item_loot_template")]
    public class CItemLootTemplate : ItemLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public byte Maxcount { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
