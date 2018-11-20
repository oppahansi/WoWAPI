using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WNpcVendor : NpcVendorBase
    {
        public short Slot { get; set; }
        public int Item { get; set; }
        public uint ExtendedCost { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
