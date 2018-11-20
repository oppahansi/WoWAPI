using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("playercreateinfo_spell")]
    public class CPlayerCreateInfoSpell
    {
        [Key]
        public byte Race { get; set; }
        [Key]
        public byte Class { get; set; }
        [Key]
        public uint Spell { get; set; }
        public string Note { get; set; }
    }
}
