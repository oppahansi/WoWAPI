using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("spell_threat")]
    public class CSpellThreat : SpellThreatBase
    {
        public short Threat { get; set; }
        public float Multiplier { get; set; }
        public float ApBonus { get; set; }
    }
}
