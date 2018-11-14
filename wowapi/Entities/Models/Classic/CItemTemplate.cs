using System;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("item_template")]
    public class CItemTemplate : ItemTemplateBase
    {
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
        public byte ExtraFlags { get; set; }
    }
}
