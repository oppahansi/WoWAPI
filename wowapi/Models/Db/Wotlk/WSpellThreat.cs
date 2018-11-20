using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WSpellThreat : SpellThreatBase
    {
        public int? FlatMod { get; set; }
        public float PctMod { get; set; }
        public float ApPctMod { get; set; }
    }
}
