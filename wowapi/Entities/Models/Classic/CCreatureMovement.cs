using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_movement")]
    public class CCreatureMovement : IEntity
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Point { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint Waittime { get; set; }
        public uint ScriptId { get; set; }
        public string Comment { get; set; }
    }
}
