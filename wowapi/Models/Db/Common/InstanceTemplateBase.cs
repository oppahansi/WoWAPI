using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class InstanceTemplateBase
    {
        [Key]
        public ushort Map { get; set; }
        public ushort Parent { get; set; }
    }
}
