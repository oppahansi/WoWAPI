using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class ItemEnchantmentTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Ench { get; set; }
    }
}
