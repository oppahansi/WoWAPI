using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("pool_template")]
    public class PoolTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        public uint MaxLimit { get; set; }
        public string Description { get; set; }
    }
}
