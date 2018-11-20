using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TCreature : CreatureBase
    {
        public byte SpawnMask { get; set; }
        public int EquipmentId { get; set; }
        public uint Spawntimesecsmin { get; set; }
        public uint Spawntimesecsmax { get; set; }
        public byte DeathState { get; set; }
    }
}
