using System;
namespace wowapi.Entities.ModelsPrepared
{
    public class ItemDetailsBase
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


   "nslots":null

        public ItemDetailsBase()
        {
        }
    }
}
