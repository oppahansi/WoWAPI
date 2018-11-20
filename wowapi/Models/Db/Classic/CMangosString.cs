using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("mangos_string")]
    public class CMangosString
    {
        [Key]
        public uint Entry { get; set; }
        public string ContentDefault { get; set; }
        public string ContentLoc1 { get; set; }
        public string ContentLoc2 { get; set; }
        public string ContentLoc3 { get; set; }
        public string ContentLoc4 { get; set; }
        public string ContentLoc5 { get; set; }
        public string ContentLoc6 { get; set; }
        public string ContentLoc7 { get; set; }
        public string ContentLoc8 { get; set; }
    }
}
