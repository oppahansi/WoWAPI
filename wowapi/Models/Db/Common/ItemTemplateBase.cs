using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    public class ItemTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        public byte Class { get; set; }
        public byte Subclass { get; set; }
        public string Name { get; set; }
        public uint Displayid { get; set; }
        public byte Quality { get; set; }
        public uint Flags { get; set; }
        public byte BuyCount { get; set; }
        public uint SellPrice { get; set; }
        public byte InventoryType { get; set; }
        public int AllowableClass { get; set; }
        public int AllowableRace { get; set; }
        public byte RequiredLevel { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public uint Requiredspell { get; set; }
        public uint Requiredhonorrank { get; set; }
        public uint RequiredCityRank { get; set; }
        public ushort RequiredReputationFaction { get; set; }
        public ushort RequiredReputationRank { get; set; }
        public byte ContainerSlots { get; set; }
        [Column("stat_type1")]
        public byte StatType1 { get; set; }
        [Column("stat_value1")]
        public short StatValue1 { get; set; }
        [Column("stat_type2")]
        public byte StatType2 { get; set; }
        [Column("stat_value2")]
        public short StatValue2 { get; set; }
        [Column("stat_type3")]
        public byte StatType3 { get; set; }
        [Column("stat_value3")]
        public short StatValue3 { get; set; }
        [Column("stat_type4")]
        public byte StatType4 { get; set; }
        [Column("stat_value4")]
        public short StatValue4 { get; set; }
        [Column("stat_type5")]
        public byte StatType5 { get; set; }
        [Column("stat_value5")]
        public short StatValue5 { get; set; }
        [Column("stat_type6")]
        public byte StatType6 { get; set; }
        [Column("stat_value6")]
        public short StatValue6 { get; set; }
        [Column("stat_type7")]
        public byte StatType7 { get; set; }
        [Column("stat_value7")]
        public short StatValue7 { get; set; }
        [Column("stat_type8")]
        public byte StatType8 { get; set; }
        [Column("stat_value8")]
        public short StatValue8 { get; set; }
        [Column("stat_type9")]
        public byte StatType9 { get; set; }
        [Column("stat_value9")]
        public short StatValue9 { get; set; }
        [Column("stat_type10")]
        public byte StatType10 { get; set; }
        [Column("stat_value10")]
        public short StatValue10 { get; set; }
        [Column("dmg_min1")]
        public float DmgMin1 { get; set; }
        [Column("dmg_max1")]
        public float DmgMax1 { get; set; }
        [Column("dmg_type1")]
        public byte DmgType1 { get; set; }
        [Column("dmg_min2")]
        public float DmgMin2 { get; set; }
        [Column("dmg_max2")]
        public float DmgMax2 { get; set; }
        [Column("dmg_type2")]
        public byte DmgType2 { get; set; }
        public ushort Armor { get; set; }
        [Column("holy_res")]
        public byte HolyRes { get; set; }
        [Column("fire_res")]
        public byte FireRes { get; set; }
        [Column("nature_res")]
        public byte NatureRes { get; set; }
        [Column("frost_res")]
        public byte FrostRes { get; set; }
        [Column("shadow_res")]
        public byte ShadowRes { get; set; }
        [Column("arcane_res")]
        public byte ArcaneRes { get; set; }
        public ushort Delay { get; set; }
        [Column("ammo_type")]
        public byte AmmoType { get; set; }
        public float RangedModRange { get; set; }
        [Column("spelltrigger_1")]
        public byte Spelltrigger1 { get; set; }
        [Column("spellppmRate_1")]
        public float SpellppmRate1 { get; set; }
        [Column("spellcooldown_1")]
        public int Spellcooldown1 { get; set; }
        [Column("spellcategory_1")]
        public ushort Spellcategory1 { get; set; }
        [Column("spellcategorycooldown_1")]
        public int Spellcategorycooldown1 { get; set; }
        [Column("spelltrigger_2")]
        public byte Spelltrigger2 { get; set; }
        [Column("spellppmRate_2")]
        public float SpellppmRate2 { get; set; }
        [Column("spellcooldown_2")]
        public int Spellcooldown2 { get; set; }
        [Column("spellcategory_2")]
        public ushort Spellcategory2 { get; set; }
        [Column("spellcategorycooldown_2")]
        public int Spellcategorycooldown2 { get; set; }
        [Column("spelltrigger_3")]
        public byte Spelltrigger3 { get; set; }
        [Column("spellppmRate_3")]
        public float SpellppmRate3 { get; set; }
        [Column("spellcooldown_3")]
        public int Spellcooldown3 { get; set; }
        [Column("spellcategory_3")]
        public ushort Spellcategory3 { get; set; }
        [Column("spellcategorycooldown_3")]
        public int Spellcategorycooldown3 { get; set; }
        [Column("spelltrigger_4")]
        public byte Spelltrigger4 { get; set; }
        [Column("spellppmRate_4")]
        public float SpellppmRate4 { get; set; }
        [Column("spellcooldown_4")]
        public int Spellcooldown4 { get; set; }
        [Column("spellcategory_4")]
        public ushort Spellcategory4 { get; set; }
        [Column("spellcategorycooldown_4")]
        public int Spellcategorycooldown4 { get; set; }
        [Column("spelltrigger_5")]
        public byte Spelltrigger5 { get; set; }
        [Column("spellppmRate_5")]
        public float SpellppmRate5 { get; set; }
        [Column("spellcooldown_5")]
        public int Spellcooldown5 { get; set; }
        [Column("spellcategory_5")]
        public ushort Spellcategory5 { get; set; }
        [Column("spellcategorycooldown_5")]
        public int Spellcategorycooldown5 { get; set; }
        public byte Bonding { get; set; }
        public string Description { get; set; }
        public uint PageText { get; set; }
        public byte LanguageId { get; set; }
        public byte PageMaterial { get; set; }
        public uint Startquest { get; set; }
        public uint Lockid { get; set; }
        public sbyte Material { get; set; }
        public byte Sheath { get; set; }
        public uint Block { get; set; }
        public uint Itemset { get; set; }
        public ushort MaxDurability { get; set; }
        public uint Area { get; set; }
        public short Map { get; set; }
        public int BagFamily { get; set; }
        public string ScriptName { get; set; }
        public uint DisenchantId { get; set; }
        public byte FoodType { get; set; }
        public uint MinMoneyLoot { get; set; }
        public uint MaxMoneyLoot { get; set; }
        public uint Duration { get; set; }
    }
}
