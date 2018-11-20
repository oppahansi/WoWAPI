using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class SpellTargetPositionBase
    {
        [Key]
        public uint Id { get; set; }
    }
}
