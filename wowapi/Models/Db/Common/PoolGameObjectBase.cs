using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("pool_gameobject")]
    public class PoolGameObjectBase
    {
        [Key]
        public uint Guid { get; set; }
        public uint PoolEntry { get; set; }
        public string Description { get; set; }
    }
}
