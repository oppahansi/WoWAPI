using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("player_levelstats")]
    public class PlayerLevelStatsBase : IEntity
    {
        [Key]
        public byte Race { get; set; }
        [Key]
        public byte Class { get; set; }
        [Key]
        public byte Level { get; set; }
        public byte Str { get; set; }
        public byte Agi { get; set; }
        public byte Sta { get; set; }
        public byte Inte { get; set; }
        public byte Spi { get; set; }
    }
}
