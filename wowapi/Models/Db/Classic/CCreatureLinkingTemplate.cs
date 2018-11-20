using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_linking_template")]
    public class CCreatureLinkingTemplate
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public ushort Map { get; set; }
        public uint MasterEntry { get; set; }
        public uint Flag { get; set; }
        public uint SearchRange { get; set; }
    }
}
