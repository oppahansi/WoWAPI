using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class CreatureTemplateAddonBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public uint Mount { get; set; }
        public uint Bytes1 { get; set; }
        public uint Emote { get; set; }
        public string Auras { get; set; }
    }
}
