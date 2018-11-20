using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("command")]
    public class CCommand : CommandBase
    {
        public byte Security { get; set; }
    }
}
