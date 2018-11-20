using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class GossipMenuBase
    {
        [Key]
        public uint TextId { get; set; }
    }
}
