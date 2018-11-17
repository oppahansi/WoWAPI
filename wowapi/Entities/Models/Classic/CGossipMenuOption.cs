using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("gossip_menu_option")]
    public class CGossipMenuOption : GossipMenuOptionBase
    {
        [Key]
        public ushort Id { get; set; }
        public byte OptionId { get; set; }
        public uint NpcOptionNpcflag { get; set; }
        public int ActionMenuId { get; set; }
        public uint ActionScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
