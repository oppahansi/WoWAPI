using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("pool_gameobject_template")]
    public class CPoolGameObjectTemplate
    {
        [Key]
        public uint Id { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; }
    }
}
