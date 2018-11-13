using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TSpellThreat : SpellThreatBase
    {
        public short Threat { get; set; }
        public float Multiplier { get; set; }
        public float ApBonus { get; set; }
    }
}
