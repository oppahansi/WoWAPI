using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WCreatureAddon : CreatureAddonBase
    {
        public uint PathId { get; set; }
        public uint Bytes2 { get; set; }
    }
}
