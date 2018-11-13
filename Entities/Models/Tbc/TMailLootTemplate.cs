using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TMailLootTemplate : MailLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
