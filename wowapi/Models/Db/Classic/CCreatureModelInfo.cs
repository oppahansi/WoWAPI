using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
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
