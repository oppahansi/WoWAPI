using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("npc_vendor")]
    public class CNpcVendor : NpcVendorBase
    {
        [Key]
        public uint Item { get; set; }
        public uint ConditionId { get; set; }
    }
}
