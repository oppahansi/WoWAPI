using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("playercreateinfo")]
    public class PlayerCreateInfoBase : IEntity
    {
        [Key]
        public byte Race { get; set; }
        [Key]
        public byte Class { get; set; }
        public ushort Map { get; set; }
        public uint Zone { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
    }
}
