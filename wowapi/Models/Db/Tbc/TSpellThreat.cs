using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TSpellThreat : SpellThreatBase
    {
        public short Threat { get; set; }
        public float Multiplier { get; set; }
        public float ApBonus { get; set; }
    }
}
