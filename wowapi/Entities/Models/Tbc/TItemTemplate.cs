using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TItemTemplate : ItemTemplateBase
    {
        public int Unk0 { get; set; }
        public uint BuyPrice { get; set; }
        public byte ItemLevel { get; set; }
        public ushort Maxcount { get; set; }
        public ushort Stackable { get; set; }
        public float DmgMin3 { get; set; }
        public float DmgMax3 { get; set; }
        public byte DmgType3 { get; set; }
        public float DmgMin4 { get; set; }
        public float DmgMax4 { get; set; }
        public byte DmgType4 { get; set; }
        public float DmgMin5 { get; set; }
        public float DmgMax5 { get; set; }
        public byte DmgType5 { get; set; }
        public uint Spellid1 { get; set; }
        public sbyte Spellcharges1 { get; set; }
        public uint Spellid2 { get; set; }
        public sbyte Spellcharges2 { get; set; }
        public uint Spellid3 { get; set; }
        public sbyte Spellcharges3 { get; set; }
        public uint Spellid4 { get; set; }
        public sbyte Spellcharges4 { get; set; }
        public uint Spellid5 { get; set; }
        public sbyte Spellcharges5 { get; set; }
        public uint RandomProperty { get; set; }
        public uint RandomSuffix { get; set; }
        public sbyte TotemCategory { get; set; }
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
        public byte ExtraFlags { get; set; }
    }
}
