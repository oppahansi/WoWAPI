using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WCreatureModelInfo : CreatureModelInfoBase
    {
        public uint DisplayId { get; set; }
        public uint DisplayIdOtherGender { get; set; }
    }
}
