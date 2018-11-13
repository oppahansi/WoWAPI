using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("instance_encounters")]
    public class CInstanceEncounters : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public ushort LastEncounterDungeon { get; set; }
    }
}
