using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("spell_bonus_data")]
    public class CSpellBonusData : SpellBonusDataBase
    {
        [Key]
        public ushort Entry { get; set; }
    }
}
