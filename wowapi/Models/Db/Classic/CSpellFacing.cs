using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_facing")]
    public class CSpellFacing
    {
        [Key]
        public uint Entry { get; set; }
        public sbyte Facingcasterflag { get; set; }
    }
}
