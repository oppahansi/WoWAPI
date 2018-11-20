using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TCreatureModelInfo : CreatureModelInfoBase
    {
        public uint Modelid { get; set; }
        public float SpeedWalk { get; set; }
        public float SpeedRun { get; set; }
        public uint ModelidOtherGender { get; set; }
        public uint ModelidAlternative { get; set; }
    }
}
