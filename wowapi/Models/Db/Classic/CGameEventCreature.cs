using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("game_event_creature")]
    public class CGameEventCreature : GameEventCreatureBase
    {
        [Key]
        public short Event { get; set; }
    }
}
