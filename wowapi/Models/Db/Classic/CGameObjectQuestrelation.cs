using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("gameobject_questrelation")]
    public class CGameObjectQuestrelation
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Quest { get; set; }
    }
}
