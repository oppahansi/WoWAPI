using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("gameobject_involvedrelation")]
    public class CGameObjectInvolvedrelation
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Quest { get; set; }
    }
}
