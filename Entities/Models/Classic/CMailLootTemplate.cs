using System;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    public class CMailLootTemplate : MailLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
