using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("game_event_gameobject")]
    public class CGameEventGameobject : GameEventGameobjectBase
    {
        [Key]
        public short Event { get; set; }
    }
}
