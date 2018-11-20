using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TNpcVendor : NpcVendorBase
    {
        public uint Item { get; set; }
        public uint ExtendedCost { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
