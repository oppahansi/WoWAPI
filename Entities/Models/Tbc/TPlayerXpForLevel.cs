using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TPlayerXpForLevel : PlayerXpForLevelBase
    {
        public uint Lvl { get; set; }
        public uint XpForNextLevel { get; set; }
    }
}
