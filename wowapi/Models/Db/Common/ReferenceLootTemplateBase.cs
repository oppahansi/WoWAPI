using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class ReferenceLootTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Groupid { get; set; }
        public byte Maxcount { get; set; }
    }
}
