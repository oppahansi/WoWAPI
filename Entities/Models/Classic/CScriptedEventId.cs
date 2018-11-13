using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("scripted_event_id")]
    public class CScriptedEventId : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ScriptName { get; set; }
    }
}
