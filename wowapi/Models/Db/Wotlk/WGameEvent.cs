using System;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WGameEvent : GameEventBase
    {
        public byte EventEntry { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public byte HolidayStage { get; set; }
        public byte WorldEvent { get; set; }
        public byte? Announce { get; set; }
    }
}
