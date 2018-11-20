using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("refrence_loot_template_names")]
    public class CReferenceLootTemplateNames
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
    }
}
