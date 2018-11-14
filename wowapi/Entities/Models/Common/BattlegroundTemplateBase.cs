using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("battleground_template")]
    public class BattlegroundTemplateBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public ushort MinPlayersPerTeam { get; set; }
        public ushort MaxPlayersPerTeam { get; set; }
        public byte MinLvl { get; set; }
        public byte MaxLvl { get; set; }
        public uint AllianceStartLoc { get; set; }
        public float AllianceStartO { get; set; }
        public uint HordeStartLoc { get; set; }
        public float HordeStartO { get; set; }
        public float StartMaxDist { get; set; }
    }
}
