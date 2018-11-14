using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
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
