using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WItemTemplate : ItemTemplateBase
    {
        public sbyte SoundOverrideSubclass { get; set; }
        public uint FlagsExtra { get; set; }
        public long BuyPrice { get; set; }
        public ushort ItemLevel { get; set; }
        public int Maxcount { get; set; }
        public int? Stackable { get; set; }
        public byte StatsCount { get; set; }
        public short ScalingStatDistribution { get; set; }
        public uint ScalingStatValue { get; set; }
        public int Spellid1 { get; set; }
        public short Spellcharges1 { get; set; }
        public int Spellid2 { get; set; }
        public short Spellcharges2 { get; set; }
        public int Spellid3 { get; set; }
        public short Spellcharges3 { get; set; }
        public int Spellid4 { get; set; }
        public short Spellcharges4 { get; set; }
        public int Spellid5 { get; set; }
        public short Spellcharges5 { get; set; }
        public int RandomProperty { get; set; }
        public uint RandomSuffix { get; set; }
        public int TotemCategory { get; set; }
        public sbyte SocketColor1 { get; set; }
        public int SocketContent1 { get; set; }
        public sbyte SocketColor2 { get; set; }
        public int SocketContent2 { get; set; }
        public sbyte SocketColor3 { get; set; }
        public int SocketContent3 { get; set; }
        public int SocketBonus { get; set; }
        public int GemProperties { get; set; }
        public short RequiredDisenchantSkill { get; set; }
        public float ArmorDamageModifier { get; set; }
        public short ItemLimitCategory { get; set; }
        public uint HolidayId { get; set; }
        public uint FlagsCustom { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
