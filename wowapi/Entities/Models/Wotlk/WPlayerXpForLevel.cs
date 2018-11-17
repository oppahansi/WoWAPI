using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WPlayerXpForLevel : PlayerXpForLevelBase
    {
        public byte Level { get; set; }
        public uint Experience { get; set; }
    }
}
