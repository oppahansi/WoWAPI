using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class ItemLootTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Groupid { get; set; }
    }
}
