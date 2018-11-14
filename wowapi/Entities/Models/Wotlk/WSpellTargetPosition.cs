using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WSpellTargetPosition : SpellTargetPositionBase
    {
        public byte EffectIndex { get; set; }
        public ushort MapId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
