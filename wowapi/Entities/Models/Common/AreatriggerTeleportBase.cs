using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class AreatriggerTeleportBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort TargetMap { get; set; }
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public float TargetPositionZ { get; set; }
        public float TargetOrientation { get; set; }
    }
}
