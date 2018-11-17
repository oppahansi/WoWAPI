using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class GossipMenuBase : IEntity
    {
        [Key]
        public uint TextId { get; set; }
    }
}
