using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TGossipMenu : GossipMenuBase
    {
        public ushort Entry { get; set; }
        public uint ScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
