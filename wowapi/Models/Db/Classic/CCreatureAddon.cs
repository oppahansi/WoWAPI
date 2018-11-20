using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_addon")]
    public class CCreatureAddon : CreatureAddonBase
    {
        public byte B20Sheath { get; set; }
        public byte B21Flags { get; set; }
        public uint Moveflags { get; set; }
    }
}
