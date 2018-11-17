using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WCreatureAddon : CreatureAddonBase
    {
        public uint PathId { get; set; }
        public uint Bytes2 { get; set; }
    }
}
