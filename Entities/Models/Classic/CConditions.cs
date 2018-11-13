using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("conditions")]
    public class CConditions : IEntity
    {
        [Key]
        public uint ConditionEntry { get; set; }
        public sbyte Type { get; set; }
        public uint Value1 { get; set; }
        public uint Value2 { get; set; }
        public string Comments { get; set; }
    }
}
