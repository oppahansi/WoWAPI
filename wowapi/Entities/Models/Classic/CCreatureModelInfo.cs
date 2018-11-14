using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_model_info")]
    public class CCreatureModelInfo : CreatureModelInfoBase
    {
        [Key]
        public uint Modelid { get; set; }
        public float SpeedWalk { get; set; }
        public float SpeedRun { get; set; }
        public uint ModelidOtherGender { get; set; }
        public uint ModelidOtherTeam { get; set; }
    }
}
