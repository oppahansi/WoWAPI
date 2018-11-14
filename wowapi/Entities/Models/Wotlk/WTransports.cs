using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WTransports : TransportsBase
    {
        public uint Guid { get; set; }
        public string ScriptName { get; set; }
    }
}
