using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class SpellTargetPositionBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
    }
}
