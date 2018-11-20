using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("exploration_baseexp")]
    public class ExplorationBasexpBase
    {
        [Key]
        public sbyte Level { get; set; }
        public int Basexp { get; set; }
    }
}
