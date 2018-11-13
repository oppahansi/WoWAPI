using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("dbscript_string_template")]
    public class CDbScriptStringTemplate : IEntity
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public int StringId { get; set; }
    }
}
