using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("npc_vendor_tempate")]
    public class CNpcVendorTemplate : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Maxcount { get; set; }
        public uint Incrtime { get; set; }
        public uint ExtendedCost { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
