using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("dbscript_random_templates")]
    public class CDbScriptRandomTemplates
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Type { get; set; }
        [Key]
        public int TargetId { get; set; }
        public int Chance { get; set; }
        public string Comments { get; set; }
    }
}
