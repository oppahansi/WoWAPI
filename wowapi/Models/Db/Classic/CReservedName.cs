using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("reserved_name")]
    public class CReservedName
    {
        [Key]
        public string Name { get; set; }
    }
}
