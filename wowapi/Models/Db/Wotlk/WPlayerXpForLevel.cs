using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WPlayerXpForLevel : PlayerXpForLevelBase
    {
        public byte Level { get; set; }
        public uint Experience { get; set; }
    }
}
