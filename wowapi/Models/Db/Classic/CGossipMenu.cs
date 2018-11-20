using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("gossip_menu")]
    public class CGossipMenu : GossipMenuBase
    {
        [Key]
        public ushort Entry { get; set; }
        [Key]
        public uint ScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
