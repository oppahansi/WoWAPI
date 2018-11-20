using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class SpellThreatBase
    {
        [Key]
        public uint Entry { get; set; }
    }
}
