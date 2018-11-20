using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class ItemEnchantmentTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Ench { get; set; }
    }
}
