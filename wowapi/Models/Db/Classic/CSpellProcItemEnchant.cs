using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_proc_item_enchant")]
    public class CSpellProcItemEnchant
    {
        [Key]
        public uint Entry { get; set; }
        public float PpmRate { get; set; }
    }
}
