using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("areatrigger_involvedrelation")]
    public class AreatriggerInvolvedrelationBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public uint Quest { get; set; }
    }
}
