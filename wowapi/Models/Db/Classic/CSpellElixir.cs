using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_elixir")]
    public class CSpellElixir
    {
        [Key]
        public uint Entry { get; set; }
        public byte Mask { get; set; }
    }
}
