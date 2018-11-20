using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("npc_vendor")]
    public class CNpcVendor : NpcVendorBase
    {
        [Key]
        public uint Item { get; set; }
        public uint ConditionId { get; set; }
    }
}
