using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_ai_summons")]
    public class CCreatureAiSummons : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint Spawntimesecs { get; set; }
        public string Comment { get; set; }
    }
}
