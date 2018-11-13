using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class GameEventCreatureBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
    }
}
