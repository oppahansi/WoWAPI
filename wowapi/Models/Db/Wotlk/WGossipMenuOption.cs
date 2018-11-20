using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WGossipMenuOption : GossipMenuOptionBase
    {
        public ushort OptionId { get; set; }
        public int OptionBroadcastTextId { get; set; }
        public byte OptionType { get; set; }
        public uint OptionNpcFlag { get; set; }
        public uint ActionMenuId { get; set; }
        public int BoxBroadcastTextId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
