using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("game_event_creature")]
    public class CGameEventCreature : GameEventCreatureBase
    {
        [Key]
        public short Event { get; set; }
    }
}
