using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("exploration_baseexp")]
    public class ExplorationBasexpBase : IEntity
    {
        [Key]
        public sbyte Level { get; set; }
        public int Basexp { get; set; }
    }
}
