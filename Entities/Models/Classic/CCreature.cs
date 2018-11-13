using System;
using Entities.Models.Common;

namespace Entities.Models.Classic
{
    public class CCreature : CreatureBase
    {
        public int EquipmentId { get; set; }
        public uint Spawntimesecsmin { get; set; }
        public uint Spawntimesecsmax { get; set; }
        public byte DeathState { get; set; }
    }
}
