using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WCreatureTemplateAddon : CreatureTemplateAddonBase
    {
        public uint PathId { get; set; }
        public uint Bytes2 { get; set; }
    }
}
