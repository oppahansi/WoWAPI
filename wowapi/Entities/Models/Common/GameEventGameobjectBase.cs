using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class GameEventGameobjectBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
    }
}
