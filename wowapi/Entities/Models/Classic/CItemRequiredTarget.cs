using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("item_required_target")]
    public class CItemRequiredTarget : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public byte Type { get; set; }
        [Key]
        public uint TargetEntry { get; set; }
    }
}
