using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_conditional_spawn")]
    public class CCreatureConditionalSpawn
    {
        [Key]
        public uint Guid { get; set; }
        public uint EntryAlliance { get; set; }
        public uint EntryHorde { get; set; }
        public string Comments { get; set; }
    }
}
