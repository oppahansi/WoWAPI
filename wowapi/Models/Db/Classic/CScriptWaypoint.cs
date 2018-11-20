using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("script_waypoint")]
    public class CScriptWaypoint : ScriptWaypointBase
    {
        [Key]
        public uint PathId { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; }
        public string PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint ScriptId { get; set; }
        public string Comment { get; set; }
    }
}
