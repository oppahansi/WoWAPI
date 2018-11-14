using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Common;

namespace Entities.Models.Classic
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
