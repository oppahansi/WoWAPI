using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TCreatureTemplateAddon : CreatureTemplateAddonBase
    {
        public byte B20Sheath { get; set; }
        public byte B21Flags { get; set; }
        public uint Moveflags { get; set; }
    }
}
