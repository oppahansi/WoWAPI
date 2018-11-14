using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class CommandBase : IEntity
    {
        [Key]
        public string Name { get; set; }
        public string Help { get; set; }
    }
}
