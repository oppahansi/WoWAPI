using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WScriptWaypoint : ScriptWaypointBase
    {
        public float LocationX { get; set; }
        public float LocationY { get; set; }
        public float LocationZ { get; set; }
        public string PointComment { get; set; }
    }
}
