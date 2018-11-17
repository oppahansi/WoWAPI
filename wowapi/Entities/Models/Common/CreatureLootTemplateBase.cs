using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class CreatureLootTemplateBase : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Item { get; set; }
        public byte Groupid { get; set; }
        public byte Maxcount { get; set; }
    }
}
