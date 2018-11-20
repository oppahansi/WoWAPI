using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("item_enchantment_template")]
    public class CItemEnchantmentTemplate : ItemEnchantmentTemplateBase
    {
        public float Chance { get; set; }
    }
}
