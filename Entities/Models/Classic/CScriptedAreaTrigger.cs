using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("scrited_areatrigger")]
    public class CScriptedAreaTrigger : IEntity
    {
        [Key]
        public int Entry { get; set; }
        public string ScriptName { get; set; }
    }
}
