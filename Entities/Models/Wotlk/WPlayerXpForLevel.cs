using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WPlayerXpForLevel : PlayerXpForLevelBase
    {
        public byte Level { get; set; }
        public uint Experience { get; set; }
    }
}
