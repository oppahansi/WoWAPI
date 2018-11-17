using System;
using wowapi.Entities.Models.Classic;
using wowapi.Utilities;

namespace wowapi.Entities.ModelsPrepared
{
    public class NpcDropItem
    {
        public uint Entry { get; set; }
        public byte Class { get; set; }
        public byte Subclass { get; set; }
        public string Name { get; set; }
        public byte Quality { get; set; }
        public byte RequiredLevel { get; set; }
        public byte ItemLevel { get; set; }
        public Tuple<byte, byte> Stack { get; }
        public float ChanceOrQuestChance { get; }
        public bool Quest { get; }
        public byte Stock { get; }
        public uint Cost { get; }
        public int MincountOrRef { get; set; }
        public float Dps { get; }
        public float Speed { get; }
        public ushort Armor { get; set; }
        public byte InventoryType { get; }
        public byte ContainerSlots { get; }

        public NpcDropItem(CItemTemplate itemTemplate)
        {
            Entry = itemTemplate.Entry;
            Class = itemTemplate.Class;
            Subclass = itemTemplate.Subclass;
            Name = itemTemplate.Name;
            Quality = itemTemplate.Quality;
            RequiredLevel = itemTemplate.RequiredLevel;
            ItemLevel = itemTemplate.ItemLevel;
            // Stack
            // ChanceOrQuestChance
            // Quest
            Cost = itemTemplate.BuyPrice;
            // MincountOrRef
            Dps = ItemUtils.CalculateItemDps(itemTemplate);
            Speed = itemTemplate.Delay / 10000.0F;
            Armor = itemTemplate.Armor;
            InventoryType = itemTemplate.InventoryType;
            ContainerSlots = itemTemplate.ContainerSlots;
        }
    }
}
