using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class ScriptWaypointBase
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Pointid { get; set; }
        public uint Waittime { get; set; }
    }
}
