using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("item_enchantment_template")]
    public class CItemEnchantmentTemplate : ItemEnchantmentTemplateBase
    {
        public float Chance { get; set; }
    }
}
