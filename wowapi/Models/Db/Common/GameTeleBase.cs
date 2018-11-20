using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("game_tele")]
    public class GameTeleBase
    {
        [Key]
        public uint Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public ushort Map { get; set; }
        public string Name { get; set; }
    }
}
