using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("petcreateinfo_spell")]
    public class CPetCreateInfoSpell
    {
        [Key]
        public uint Entry { get; set; }
        public uint Spell1 { get; set; }
        public uint Spell2 { get; set; }
        public uint Spell3 { get; set; }
        public uint Spell4 { get; set; }
    }
}
