using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WPageText : PageTextBase
    {
        public uint Id { get; set; }
        public uint NextPageId { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
