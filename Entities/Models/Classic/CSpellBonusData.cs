using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("spell_bonus_data")]
    public class CSpellBonusData : SpellBonusDataBase
    {
        [Key]
        public ushort Entry { get; set; }
    }
}
