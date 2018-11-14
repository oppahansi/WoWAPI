using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TSpellThreat : SpellThreatBase
    {
        public short Threat { get; set; }
        public float Multiplier { get; set; }
        public float ApBonus { get; set; }
    }
}
