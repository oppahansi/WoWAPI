using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("creature_ai_summons")]
    public class CCreatureAiSummons
    {
        [Key]
        public uint Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint Spawntimesecs { get; set; }
        public string Comment { get; set; }
    }
}
