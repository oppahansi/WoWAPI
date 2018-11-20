using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Classic
{
    public class CCreature : CreatureBase
    {
        [Column("equipment_id")]
        public int EquipmentId { get; set; }
        public uint Spawntimesecsmin { get; set; }
        public uint Spawntimesecsmax { get; set; }
        public byte DeathState { get; set; }
    }
}
