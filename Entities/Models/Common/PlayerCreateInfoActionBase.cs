using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("playercreateinfo_action")]
    public class PlayerCreateInfoActionBase : IEntity
    {
        [Key]
        public byte Race { get; set; }
        [Key]
        public byte Class { get; set; }
        [Key]
        public ushort Button { get; set; }
        public uint Action { get; set; }
        public ushort Type { get; set; }
    }
}
