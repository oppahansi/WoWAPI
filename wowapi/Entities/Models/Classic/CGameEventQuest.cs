using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("game_event_quest")]
    public class CGameEventQuest : IEntity
    {
        [Key]
        public uint Quest { get; set; }
        [Key]
        public ushort Event { get; set; }
    }
}
