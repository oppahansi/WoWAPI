using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WTransports : TransportsBase
    {
        public uint Guid { get; set; }
        public string ScriptName { get; set; }
    }
}
