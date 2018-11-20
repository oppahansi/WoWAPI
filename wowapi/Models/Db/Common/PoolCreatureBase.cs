using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("pool_creature")]
    public class PoolCreatureBase
    {
        [Key]
        public uint Guid { get; set; }
        public uint PoolEntry { get; set; }
        public float Change { get; set; }
        public string Description { get; set; }
    }
}
