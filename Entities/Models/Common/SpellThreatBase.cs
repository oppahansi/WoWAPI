using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class SpellThreatBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
    }
}
