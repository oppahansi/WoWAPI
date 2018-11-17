using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("pool_creature")]
    public class PoolCreatureBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public uint PoolEntry { get; set; }
        public float Change { get; set; }
        public string Description { get; set; }
    }
}
