using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Tbc
{
    public class TGameobject : GameObjectBase
    {
        public byte SpawnMask { get; set; }
        public int Spawntimesecsmin { get; set; }
        public int Spawntimesecsmax { get; set; }
    }
}
