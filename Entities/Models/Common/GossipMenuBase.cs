using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class GossipMenuBase : IEntity
    {
        [Key]
        public uint TextId { get; set; }
    }
}
