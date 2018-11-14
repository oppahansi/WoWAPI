using System;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
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
