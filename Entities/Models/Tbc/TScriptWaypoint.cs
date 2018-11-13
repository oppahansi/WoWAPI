using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TScriptWaypoint : ScriptWaypointBase
    {
        public uint PathId { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; }
        public string PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint ScriptId { get; set; }
        public string Comment { get; set; }
    }
}
