using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TGossipMenuOption : GossipMenuOptionBase
    {
        public ushort Id { get; set; }
        public byte OptionId { get; set; }
        public uint NpcOptionNpcflag { get; set; }
        public int ActionMenuId { get; set; }
        public uint ActionScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
