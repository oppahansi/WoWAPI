using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("scripted_event_id")]
    public class CScriptedEventId
    {
        [Key]
        public int Id { get; set; }
        public string ScriptName { get; set; }
    }
}
