using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("scrited_areatrigger")]
    public class CScriptedAreaTrigger
    {
        [Key]
        public int Entry { get; set; }
        public string ScriptName { get; set; }
    }
}
