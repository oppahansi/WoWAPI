using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("npc_vendor")]
    public class CNpcVendor : NpcVendorBase
    {
        [Key]
        public uint Item { get; set; }
        public uint ConditionId { get; set; }
    }
}
