using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WPageText : PageTextBase
    {
        public uint Id { get; set; }
        public uint NextPageId { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
