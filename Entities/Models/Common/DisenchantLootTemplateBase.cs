using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class DisenchantLootTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Groupid { get; set; }
        public byte Maxcount { get; set; }
    }
}
