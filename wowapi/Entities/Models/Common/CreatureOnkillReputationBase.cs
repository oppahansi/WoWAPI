using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("creature_onkill_reputation")]
    public class CreatureOnkillReputationBase : IEntity
    {
        [Key]
        public uint CreatureId { get; set; }
        public short RewOnKillRepFaction1 { get; set; }
        public short RewOnKillRepFaction2 { get; set; }
        public sbyte MaxStanding1 { get; set; }
        public sbyte IsTeamAward1 { get; set; }
        public int RewOnKillRepValue1 { get; set; }
        public sbyte MaxStanding2 { get; set; }
        public sbyte IsTeamAward2 { get; set; }
        public int RewOnKillRepValue2 { get; set; }
        public byte TeamDependent { get; set; }
    }
}
