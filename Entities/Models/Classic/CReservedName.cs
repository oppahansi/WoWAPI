using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("reserved_name")]
    public class CReservedName : IEntity
    {
        [Key]
        public string Name { get; set; }
    }
}
