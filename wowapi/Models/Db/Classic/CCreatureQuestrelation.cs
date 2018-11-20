using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_questrelation")]
    public class CCreatureQuestrelation
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Quest { get; set; }
    }
}
