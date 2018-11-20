using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("creature")]
    public class CreatureBase    
    {
        [Key]
        public uint Guid { get; set; }
        public uint Id { get; set; }
        public ushort Map { get; set; }
        public uint Modelid { get; set; }
        [Column("position_x")]
        public float PositionX { get; set; }
        [Column("position_y")]
        public float PositionY { get; set; }
        [Column("position_z")]
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public float Spawndist { get; set; }
        public uint Currentwaypoint { get; set; }
        public uint Curhealth { get; set; }
        public uint Curmana { get; set; }
        public byte MovementType { get; set; }
    }
}
