using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("pool_pool")]
    public class PoolPoolBase
    {
        [Key]
        public uint PoolId { get; set; }
        public uint MotherPool { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; }
    }
}
