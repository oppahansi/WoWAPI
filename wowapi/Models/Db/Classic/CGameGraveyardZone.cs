using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("game_graveyard_zone")]
    public class CGameGraveyardZone
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint GhostZone { get; set; }
        public ushort Faction { get; set; }
    }
}
