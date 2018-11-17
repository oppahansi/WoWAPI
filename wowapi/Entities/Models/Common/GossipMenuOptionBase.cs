using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class GossipMenuOptionBase : IEntity
    {
        [Key]
        public ushort MenuId { get; set; }
        public uint OptionIcon { get; set; }
        public string OptionText { get; set; }
        public uint ActionPoiId { get; set; }
        public byte BoxCoded { get; set; }
        public uint BoxMoney { get; set; }
        public string BoxText { get; set; }
    }
}
