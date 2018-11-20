using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("player_xp_for_level")]
    public class CPlayerXpForLevel
    {
        [Key]
        public uint Lvl { get; set; }
        public uint XpForNextLevel { get; set; }
    }
}
