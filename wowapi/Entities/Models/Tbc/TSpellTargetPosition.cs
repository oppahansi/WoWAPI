using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
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
