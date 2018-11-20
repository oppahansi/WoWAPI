using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_linking")]
    public class CCreatureLinking
    {
        public uint Guid { get; set; }
        public uint MasterGuid { get; set; }
        public uint Flag { get; set; }
    }
}
