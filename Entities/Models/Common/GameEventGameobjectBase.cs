using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class GameEventGameobjectBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
    }
}
