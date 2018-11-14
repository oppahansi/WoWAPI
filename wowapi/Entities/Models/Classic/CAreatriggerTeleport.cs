using System;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("areatrigger_teleport")]
    public class CAreatriggerTeleport : AreatriggerTeleportBase
    {
        public byte RequiredLevel { get; set; }
        public uint RequiredItem { get; set; }
        public uint RequiredItem2 { get; set; }
        public uint RequiredQuestDone { get; set; }
        public string StatusFailedText { get; set; }
        public uint ConditionId { get; set; }
    }
}
