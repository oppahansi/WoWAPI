using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("")]
    public class CBugreport
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
