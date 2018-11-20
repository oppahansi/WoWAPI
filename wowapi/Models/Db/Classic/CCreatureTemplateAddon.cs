using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_template_addon")]
    public class CCreatureTemplateAddon : CreatureTemplateAddonBase
    {
        public byte B20Sheath { get; set; }
        public byte B21Flags { get; set; }
        public uint Moveflags { get; set; }
    }
}
