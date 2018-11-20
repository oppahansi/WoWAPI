using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("gameobject_battleground")]
    public class CGameObjectBattleground
    {
        [Key]
        public uint Guid { get; set; }
        public byte Event1 { get; set; }
        public byte Event2 { get; set; }
    }
}
