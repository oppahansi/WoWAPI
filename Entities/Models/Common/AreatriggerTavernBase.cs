using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("areatrigger_tavern")]
    public class AreatriggerTavernBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public string Name { get; set; }
    }
}
