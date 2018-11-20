using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("game_event_quest")]
    public class CGameEventQuest
    {
        [Key]
        public uint Quest { get; set; }
        [Key]
        public ushort Event { get; set; }
    }
}
