using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_battleground")]
    public class CCreatureBattleground
    {
        [Key]
        public uint Guid { get; set; }
        public byte Event1 { get; set; }
        public byte Event2 { get; set; }
    }
}
