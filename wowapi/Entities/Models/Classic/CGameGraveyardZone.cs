using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("game_graveyard_zone")]
    public class CGameGraveyardZone : IEntity
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint GhostZone { get; set; }
        public ushort Faction { get; set; }
    }
}
