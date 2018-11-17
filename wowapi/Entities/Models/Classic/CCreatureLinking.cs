using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_linking")]
    public class CCreatureLinking : IEntity
    {
        public uint Guid { get; set; }
        public uint MasterGuid { get; set; }
        public uint Flag { get; set; }
    }
}
