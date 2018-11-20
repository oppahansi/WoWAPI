using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class NpcVendorBase
    {
        [Key]
        public uint Entry { get; set; }
        public byte Maxcount { get; set; }
        public uint Incrtime { get; set; }
    }
}
