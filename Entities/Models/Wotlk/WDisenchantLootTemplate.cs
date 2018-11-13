using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WDisenchantLootTemplate : DisenchantLootTemplateBase
    {
        public uint Reference { get; set; }
        public float Chance { get; set; }
        public sbyte QuestRequired { get; set; }
        public ushort LootMode { get; set; }
        public byte MinCount { get; set; }
        public string Comment { get; set; }
    }
}
