using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class SpellTargetPositionBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
    }
}
