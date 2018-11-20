using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("dbscript_string_template")]
    public class CDbScriptStringTemplate
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public int StringId { get; set; }
    }
}
