using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("game_event")]
    public class CGameEvent : GameEventBase
    {
        [Key]
        public uint Entry { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public uint LinkedTo { get; set; }
    }
}
