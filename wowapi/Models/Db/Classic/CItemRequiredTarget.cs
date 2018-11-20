using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("item_required_target")]
    public class CItemRequiredTarget
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public byte Type { get; set; }
        [Key]
        public uint TargetEntry { get; set; }
    }
}
