using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_involvedrelation")]
    public class CCreatureInvolvedrelation
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Quest { get; set; }
    }
}
