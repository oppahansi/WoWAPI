using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class InstanceTemplateBase : IEntity
    {
        [Key]
        public ushort Map { get; set; }
        public ushort Parent { get; set; }
    }
}
