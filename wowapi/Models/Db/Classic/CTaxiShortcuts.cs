using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("taxi_shortcuts")]
    public class CTaxiShortcuts
    {
        [Key]
        public uint Pathid { get; set; }
        public uint Takeoff { get; set; }
        public uint Landing { get; set; }
        public string Comments { get; set; }
    }
}
