using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("spell_facing")]
    public class CSpellFacing : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public sbyte Facingcasterflag { get; set; }
    }
}
