using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WCreatureEquipTemplate
    {
        public uint CreatureId { get; set; }
        public byte Id { get; set; }
        public uint ItemId1 { get; set; }
        public uint ItemId2 { get; set; }
        public uint ItemId3 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
