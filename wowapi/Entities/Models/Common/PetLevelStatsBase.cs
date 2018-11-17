using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("pet_levelstats")]
    public class PetLevelStatsBase : IEntity
    {
        [Key]
        public uint CreatureEntry { get; set; }
        [Key]
        public byte Level { get; set; }
        public ushort Hp { get; set; }
        public ushort Mana { get; set; }
        public uint Armor { get; set; }
        public ushort Str { get; set; }
        public ushort Agi { get; set; }
        public ushort Sta { get; set; }
        public ushort Inte { get; set; }
        public ushort Spi { get; set; }
    }
}
