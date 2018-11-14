using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("game_event_gameobject")]
    public class CGameEventGameobject : GameEventGameobjectBase
    {
        [Key]
        public short Event { get; set; }
    }
}
