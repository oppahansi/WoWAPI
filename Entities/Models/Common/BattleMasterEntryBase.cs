using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Common
{
    [Table("battlemaster_entry")]
    public class BattleMasterEntryBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public uint BgTemplate { get; set; }
    }
}
