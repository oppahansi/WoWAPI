using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TNpcVendor : NpcVendorBase
    {
        public uint Item { get; set; }
        public uint ExtendedCost { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
