using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WBattlegroundTemplate : BattlegroundTemplateBase
    {
        public byte Weight { get; set; }
        public string ScriptName { get; set; }
        public string Comment { get; set; }
    }
}
