using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("dbscript_random_templates")]
    public class CDbScriptRandomTemplates : IEntity
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
