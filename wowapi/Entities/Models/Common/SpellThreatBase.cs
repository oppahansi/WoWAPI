using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class SpellThreatBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
    }
}
