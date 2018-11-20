using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class TransportsBase
    {
        [Key]
        public uint Entry { get; set; }
        public string Name { get; set; }
    }
}
