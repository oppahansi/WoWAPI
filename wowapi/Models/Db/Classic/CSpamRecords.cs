using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("spam_records")]
    public class CSpamRecords
    {
        [Key]
        public int Id { get; set; }
        public string Record { get; set; }
    }
}
