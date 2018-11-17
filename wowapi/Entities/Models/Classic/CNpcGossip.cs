using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("npc_gossip")]
    public class CNpcGossip : IEntity
    {
        [Key]
        public uint NpcGuid { get; set; }
        public uint Textid { get; set; }
    }
}
