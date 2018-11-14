using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("spell_affect")]
    public class CSpellAffect : IEntity
    {
        [Key]
        public ushort Entry { get; set; }
        [Key]
        public byte EffectId { get; set; }
        public ulong SpellFamilyMask { get; set; }
    }
}
