using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("world_template")]
    public class CWorldTemplate : IEntity
    {
        [Key]
        public ushort Map { get; set; }
        public string ScriptName { get; set; }
    }
}
