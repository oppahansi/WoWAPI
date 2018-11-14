using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TGossipMenu : GossipMenuBase
    {
        public ushort Entry { get; set; }
        public uint ScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
