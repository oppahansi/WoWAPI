using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WBattlegroundTemplate : BattlegroundTemplateBase
    {
        public byte Weight { get; set; }
        public string ScriptName { get; set; }
        public string Comment { get; set; }
    }
}
