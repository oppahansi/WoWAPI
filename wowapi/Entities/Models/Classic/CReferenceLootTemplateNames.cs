using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("refrence_loot_template_names")]
    public class CReferenceLootTemplateNames : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
    }
}
