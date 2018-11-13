using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("spell_script_target")]
    public class CSpellScriptTarget : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public byte Type { get; set; }
        [Key]
        public uint TargetEntry { get; set; }
        public uint InverseEffectMask { get; set; }
    }
}
