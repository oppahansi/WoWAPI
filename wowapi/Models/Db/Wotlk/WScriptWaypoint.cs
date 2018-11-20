using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WScriptWaypoint : ScriptWaypointBase
    {
        public float LocationX { get; set; }
        public float LocationY { get; set; }
        public float LocationZ { get; set; }
        public string PointComment { get; set; }
    }
}
