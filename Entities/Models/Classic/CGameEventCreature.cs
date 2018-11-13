using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("game_event_creature")]
    public class CGameEventCreature : GameEventCreatureBase
    {
        [Key]
        public short Event { get; set; }
    }
}
