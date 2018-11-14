using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("playercreateinfo_item")]
    public class PlayerCreateInfoItemBase
    {
        public byte Race { get; set; }
        public byte Class { get; set; }
        public uint Itemid { get; set; }
        public sbyte Amount { get; set; }
    }
}
