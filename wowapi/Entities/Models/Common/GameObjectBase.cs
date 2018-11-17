﻿using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class GameObjectBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public uint Id { get; set; }
        public ushort Map { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public float Rotation0 { get; set; }
        public float Rotation1 { get; set; }
        public float Rotation2 { get; set; }
        public float Rotation3 { get; set; }
        public byte Animprogress { get; set; }
        public byte State { get; set; }
    }
}
