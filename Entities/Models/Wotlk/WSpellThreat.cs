using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WSpellThreat : SpellThreatBase
    {
        public int? FlatMod { get; set; }
        public float PctMod { get; set; }
        public float ApPctMod { get; set; }
    }
}
