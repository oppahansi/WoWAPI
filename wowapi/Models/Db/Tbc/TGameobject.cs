using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TGameobject : GameObjectBase
    {
        public byte SpawnMask { get; set; }
        public int Spawntimesecsmin { get; set; }
        public int Spawntimesecsmax { get; set; }
    }
}
