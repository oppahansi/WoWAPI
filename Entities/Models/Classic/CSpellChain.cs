using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("spell_chain")]
    public class CSpellChain : IEntity
    {
        [Key]
        public int SpellId { get; set; }
        public int PrevSpell { get; set; }
        public int FirstSpell { get; set; }
        public sbyte Rank { get; set; }
        public int ReqSpell { get; set; }
    }
}
