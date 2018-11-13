using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class NpcVendorBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public byte Maxcount { get; set; }
        public uint Incrtime { get; set; }
    }
}
