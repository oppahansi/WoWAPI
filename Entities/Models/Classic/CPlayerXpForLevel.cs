using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("player_xp_for_level")]
    public class CPlayerXpForLevel : IEntity
    {
        [Key]
        public uint Lvl { get; set; }
        public uint XpForNextLevel { get; set; }
    }
}
