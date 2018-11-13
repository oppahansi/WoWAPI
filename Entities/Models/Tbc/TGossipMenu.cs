using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TGossipMenu : GossipMenuBase
    {
        public ushort Entry { get; set; }
        public uint ScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
