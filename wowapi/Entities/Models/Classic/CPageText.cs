using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("page_text")]
    public class CPageText : PageTextBase
    {
        [Key]
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
