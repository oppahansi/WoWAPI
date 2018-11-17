using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("scrited_areatrigger")]
    public class CScriptedAreaTrigger : IEntity
    {
        [Key]
        public int Entry { get; set; }
        public string ScriptName { get; set; }
    }
}
