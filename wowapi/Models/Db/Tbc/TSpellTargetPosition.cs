using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TSpellTargetPosition : SpellTargetPositionBase
    {
        public ushort TargetMap { get; set; }
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public float TargetPositionZ { get; set; }
        public float TargetOrientation { get; set; }
    }
}
