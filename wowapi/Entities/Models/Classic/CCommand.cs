using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("command")]
    public class CCommand : CommandBase
    {
        public byte Security { get; set; }
    }
}
