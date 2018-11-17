using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class ScriptWaypointBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Pointid { get; set; }
        public uint Waittime { get; set; }
    }
}
