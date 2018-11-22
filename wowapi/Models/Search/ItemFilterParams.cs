namespace wowapi.Models.Search
{
    public class ItemFilterParams : FilterParams
    {
        public byte Class { get; set; } = 100;
        public byte Subclass { get; set; } = 100;
        public string Name { get; set; } = null;
        public byte Quality { get; set; } = 100;
        public uint Flags { get; set; } = 0;
        public byte InventoryType { get; set; } = 100;
        public int AllowableClass { get; set; } = -2;
        public int AllowableRace { get; set; } = -2;
        public byte RequiredLevel { get; set; } = 0;
        public ushort RequiredSkill { get; set; } = 0;
        public ushort RequiredSkillRank { get; set; } = 0;
        public uint RequiredSpell { get; set; } = 0;
        public uint RequiredHonorRank { get; set; } = 0;
        public uint RequiredCityRank { get; set; } = 0;
        public ushort RequiredReputationFaction { get; set; } = 0;
        public ushort RequiredReputationRank { get; set; } = 0;
        public byte ContainerSlots { get; set; } = 0;
        public byte StatType { get; set; } = 100;
        public short StatValue { get; set; } = 0;
        public float Dps { get; set; } = 0;
        public float DmgMin { get; set; } = 0;
        public float DmgMax { get; set; } = 0;
        public byte DmgType { get; set; } = 100;
        public ushort Armor { get; set; } = 0;
        public byte Resistance { get; set; } = 0;
        public byte HolyRes { get; set; } = 0;
        public byte FireRes { get; set; } = 0;
        public byte NatureRes { get; set; } = 0;
        public byte FrostRes { get; set; } = 0;
        public byte ShadowRes { get; set; } = 0;
        public byte ArcaneRes { get; set; } = 0;
        public ushort Speed { get; set; } = 0;
        public byte AmmoType { get; set; } = 0;
        public byte SpellTrigger { get; set; } = 100;
        public byte Bonding { get; set; } = 0;
        public string Description { get; set; } = null;
        public uint StartQuest { get; set; } = 0;
        public uint LockId { get; set; } = 0;
        public sbyte Material { get; set; } = 0;
        public byte Sheath { get; set; } = 0;
        public uint Block { get; set; } = 0;
        public uint ItemSet { get; set; } = 0;
        public ushort Durability { get; set; } = 0;
        public uint Area { get; set; } = 100;
        public short Map { get; set; } = 100;
        public int BagFamily { get; set; } = 0;
        public uint DisenchantId { get; set; } = 0;
        public byte FoodType { get; set; } = 0;
        public uint MoneyLoot { get; set; } = 0;
        public uint Duration { get; set; } = 0;
    }
}