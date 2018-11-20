using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class GameEventGameobjectBase
    {
        [Key]
        public uint Guid { get; set; }
    }
}
