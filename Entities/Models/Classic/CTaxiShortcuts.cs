using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("taxi_shortcuts")]
    public class CTaxiShortcuts : IEntity
    {
        [Key]
        public uint Pathid { get; set; }
        public uint Takeoff { get; set; }
        public uint Landing { get; set; }
        public string Comments { get; set; }
    }
}
