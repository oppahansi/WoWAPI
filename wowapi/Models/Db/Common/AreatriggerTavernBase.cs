using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Common
{
    [Table("areatrigger_tavern")]
    public class AreatriggerTavernBase
    {
        [Key]
        public uint Id { get; set; }
        public string Name { get; set; }
    }
}
