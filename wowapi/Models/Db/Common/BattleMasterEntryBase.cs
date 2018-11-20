using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("battlemaster_entry")]
    public class BattleMasterEntryBase
    {
        [Key]
        public uint Entry { get; set; }
        public uint BgTemplate { get; set; }
    }
}
