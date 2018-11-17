using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class TransportsBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
    }
}
