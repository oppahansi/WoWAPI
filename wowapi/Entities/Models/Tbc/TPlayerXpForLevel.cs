using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TPlayerXpForLevel : PlayerXpForLevelBase
    {
        public uint Lvl { get; set; }
        public uint XpForNextLevel { get; set; }
    }
}
