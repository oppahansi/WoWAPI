using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("pool_creature_template")]
    public class CPoolCreatureTemplate
    {
        [Key]
        public uint Id { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; }
    }
}
