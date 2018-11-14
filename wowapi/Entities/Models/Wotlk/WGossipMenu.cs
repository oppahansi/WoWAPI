using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WGossipMenu : GossipMenuBase
    {
        public ushort MenuId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
