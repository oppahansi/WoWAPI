using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TCreatureTemplateAddon : CreatureTemplateAddonBase
    {
        public byte B20Sheath { get; set; }
        public byte B21Flags { get; set; }
        public uint Moveflags { get; set; }
    }
}
