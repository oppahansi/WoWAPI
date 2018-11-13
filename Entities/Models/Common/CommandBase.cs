using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class CommandBase : IEntity
    {
        [Key]
        public string Name { get; set; }
        public string Help { get; set; }
    }
}
