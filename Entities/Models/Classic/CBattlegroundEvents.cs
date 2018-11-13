using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("battleground_events")]
    public class CBattlegroundEvents : IEntity
    {
        [Key]
        public short Map { get; set; }
        [Key]
        public byte Event1 { get; set; }
        [Key]
        public byte Event2 { get; set; }
        public string Description { get; set; }
    }
}
