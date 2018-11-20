using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("areatrigger_involvedrelation")]
    public class AreatriggerInvolvedrelationBase
    {
        [Key]
        public uint Id { get; set; }
        public uint Quest { get; set; }
    }
}
