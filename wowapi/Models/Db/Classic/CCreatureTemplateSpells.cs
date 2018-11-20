using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_template_spells")]
    public class CCreatureTemplateSpells
    {
        [Key]
        public uint Entry { get; set; }
        public uint Spell1 { get; set; }
        public uint Spell2 { get; set; }
        public uint Spell3 { get; set; }
        public uint Spell4 { get; set; }
        public uint Spell5 { get; set; }
        public uint Spell6 { get; set; }
        public uint Spell7 { get; set; }
        public uint Spell8 { get; set; }
    }
}
