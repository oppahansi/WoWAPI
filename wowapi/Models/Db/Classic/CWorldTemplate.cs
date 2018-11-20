using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("world_template")]
    public class CWorldTemplate
    {
        [Key]
        public ushort Map { get; set; }
        public string ScriptName { get; set; }
    }
}
