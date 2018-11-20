using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class CommandBase
    {
        [Key]
        public string Name { get; set; }
        public string Help { get; set; }
    }
}
