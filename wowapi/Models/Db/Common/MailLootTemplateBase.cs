using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("mail_loot_template")]
    public class MailLootTemplateBase
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Groupid { get; set; }
        public byte Maxcount { get; set; }
    }
}
