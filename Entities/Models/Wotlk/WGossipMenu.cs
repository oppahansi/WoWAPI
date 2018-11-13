using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WGossipMenu : GossipMenuBase
    {
        public ushort MenuId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
