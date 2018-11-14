using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WCreatureModelInfo : CreatureModelInfoBase
    {
        public uint DisplayId { get; set; }
        public uint DisplayIdOtherGender { get; set; }
    }
}
