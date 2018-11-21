namespace wowapi.Models.Search
{
    public class ItemFilterParams : FilterParams
    {
        public uint Entry { get; set; }
        public byte Class { get; set; } = 100;
        public byte Subclass { get; set; } = 100;
        public string Name { get; set; } = null;
        public byte Quality { get; set; } = 100;
        public uint Flags { get; set; } = 0;
        public byte InventoryType { get; set; } = 100;
        public int AllowableClass { get; set; } = -2;
        public int AllowableRace { get; set; } = -2;
        public byte RequiredLevel { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public uint Requiredspell { get; set; }
        public uint Requiredhonorrank { get; set; }
        public uint RequiredCityRank { get; set; }
        public ushort RequiredReputationFaction { get; set; }
        public ushort RequiredReputationRank { get; set; }
        public byte ContainerSlots { get; set; }
        public byte StatType1 { get; set; }
        public short StatValue1 { get; set; }
        public byte StatType2 { get; set; }
        public short StatValue2 { get; set; }
        public byte StatType3 { get; set; }
        public short StatValue3 { get; set; }
        public byte StatType4 { get; set; }
        public short StatValue4 { get; set; }
        public byte StatType5 { get; set; }
        public short StatValue5 { get; set; }
        public byte StatType6 { get; set; }
        public short StatValue6 { get; set; }
        public byte StatType7 { get; set; }
        public short StatValue7 { get; set; }
        public byte StatType8 { get; set; }
        public short StatValue8 { get; set; }
        public byte StatType9 { get; set; }
        public short StatValue9 { get; set; }
        public byte StatType10 { get; set; }
        public short StatValue10 { get; set; }
        public float DmgMin1 { get; set; }
        public float DmgMax1 { get; set; }
        public byte DmgType1 { get; set; }
        public float DmgMin2 { get; set; }
        public float DmgMax2 { get; set; }
        public byte DmgType2 { get; set; }
        public ushort Armor { get; set; }
        public byte HolyRes { get; set; }
        public byte FireRes { get; set; }
        public byte NatureRes { get; set; }
        public byte FrostRes { get; set; }
        public byte ShadowRes { get; set; }
        public byte ArcaneRes { get; set; }
        public ushort Delay { get; set; }
        public byte AmmoType { get; set; }
        public float RangedModRange { get; set; }
        public byte Spelltrigger1 { get; set; }
        public byte Spelltrigger2 { get; set; }
        public byte Spelltrigger3 { get; set; }
        public byte Spelltrigger4 { get; set; }
        public byte Bonding { get; set; }
        public string Description { get; set; }
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