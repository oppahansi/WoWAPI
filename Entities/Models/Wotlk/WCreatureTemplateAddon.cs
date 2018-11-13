using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WCreatureTemplateAddon : CreatureTemplateAddonBase
    {
        public uint PathId { get; set; }
        public uint Bytes2 { get; set; }
    }
}
