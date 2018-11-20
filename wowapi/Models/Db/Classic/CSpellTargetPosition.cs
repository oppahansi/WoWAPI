using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_target_position")]
    public class CSpellTargetPosition : SpellTargetPositionBase
    {
        public ushort TargetMap { get; set; }
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public float TargetPositionZ { get; set; }
        public float TargetOrientation { get; set; }
    }
}
