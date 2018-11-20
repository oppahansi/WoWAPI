using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TInstanceTemplate : InstanceTemplateBase
    {
        public byte LevelMin { get; set; }
        public byte LevelMax { get; set; }
        public byte MaxPlayers { get; set; }
        public uint ResetDelay { get; set; }
        public string ScriptName { get; set; }
        public byte MountAllowed { get; set; }
    }
}
