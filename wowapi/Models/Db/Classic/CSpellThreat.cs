using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("spell_threat")]
    public class CSpellThreat : SpellThreatBase
    {
        public short Threat { get; set; }
        public float Multiplier { get; set; }
        public float ApBonus { get; set; }
    }
}
