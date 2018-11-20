using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TPlayerXpForLevel : PlayerXpForLevelBase
    {
        public uint Lvl { get; set; }
        public uint XpForNextLevel { get; set; }
    }
}
