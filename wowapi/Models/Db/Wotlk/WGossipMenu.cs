using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WGossipMenu : GossipMenuBase
    {
        public ushort MenuId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
