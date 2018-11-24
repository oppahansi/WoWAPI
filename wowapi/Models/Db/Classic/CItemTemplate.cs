using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;
using wowapi.Models.Db.Dbc;

namespace wowapi.Models.Db.Classic
{
    [Table("item_template")]
    public class CItemTemplate : ItemTemplateBase
    {
        public uint BuyPrice { get; set; }
        public byte ItemLevel { get; set; }
        public ushort Maxcount { get; set; }
        public ushort Stackable { get; set; }
        [Column("dmg_min3")]
        public float DmgMin3 { get; set; }
        [Column("dmg_max3")]
        public float DmgMax3 { get; set; }
        [Column("dmg_type3")]
        public byte DmgType3 { get; set; }
        [Column("dmg_min4")]
        public float DmgMin4 { get; set; }
        [Column("dmg_max4")]
        public float DmgMax4 { get; set; }
        [Column("dmg_type4")]
        public byte DmgType4 { get; set; }
        [Column("dmg_min5")]
        public float DmgMin5 { get; set; }
        [Column("dmg_max5")]
        public float DmgMax5 { get; set; }
        [Column("dmg_type5")]
        public byte DmgType5 { get; set; }
        [Column("spellid_1")]
        public uint Spellid1 { get; set; }
        [Column("spellcharges_1")]
        public sbyte Spellcharges1 { get; set; }
        [Column("spellid_2")]
        public uint Spellid2 { get; set; }
        [Column("spellcharges_2")]
        public sbyte Spellcharges2 { get; set; }
        [Column("spellid_3")]
        public uint Spellid3 { get; set; }
        [Column("spellcharges_3")]
        public sbyte Spellcharges3 { get; set; }
        [Column("spellid_4")]
        public uint Spellid4 { get; set; }
        [Column("spellcharges_4")]
        public sbyte Spellcharges4 { get; set; }
        [Column("spellid_5")]
        public uint Spellid5 { get; set; }
        [Column("spellcharges_5")]
        public sbyte Spellcharges5 { get; set; }
        public uint RandomProperty { get; set; }
        public byte ExtraFlags { get; set; }

        [NotMapped]
        public CItemSet ItemSetObj { get; set; }
        [NotMapped]
        public string Icon { get; set; }
        [NotMapped]
        public IEnumerable<CCreatureTemplate> DroppedBy { get; set; }
        
    }
}
