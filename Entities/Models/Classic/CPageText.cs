using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    [Table("page_text")]
    public class CPageText : PageTextBase
    {
        [Key]
        public uint Entry { get; set; }
        public uint NextPage { get; set; }
    }
}
