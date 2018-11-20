using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_bonus_data")]
    public class CSpellBonusData : SpellBonusDataBase
    {
        [Key]
        public ushort Entry { get; set; }
    }
}
