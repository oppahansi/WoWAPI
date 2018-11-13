using System;
using Entities.Models.Common;

namespace Entities.Models.Tbc
{
    public class TGameobject : GameObjectBase
    {
        public byte SpawnMask { get; set; }
        public int Spawntimesecsmin { get; set; }
        public int Spawntimesecsmax { get; set; }
    }
}
