using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    [Table("page_text")]
    public class CPageText : PageTextBase
    {
        [Key]
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
