using System.ComponentModel.DataAnnotations;

namespace wowapi.Models.Db.Common
{
    public class GameEventCreatureBase
    {
        [Key]
        public uint Guid { get; set; }
    }
}
