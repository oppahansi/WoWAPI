using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TGameEvent : GameEventBase
    {
        public uint Entry { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public uint LinkedTo { get; set; }
        public uint EventGroup { get; set; }
    }
}
