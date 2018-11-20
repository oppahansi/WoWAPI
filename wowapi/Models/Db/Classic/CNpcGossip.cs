using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("npc_gossip")]
    public class CNpcGossip
    {
        [Key]
        public uint NpcGuid { get; set; }
        public uint Textid { get; set; }
    }
}
