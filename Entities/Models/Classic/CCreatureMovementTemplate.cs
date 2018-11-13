using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("creature_movement_template")]
    public class CCreatureMovementTemplate : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint PathId { get; set; }
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
